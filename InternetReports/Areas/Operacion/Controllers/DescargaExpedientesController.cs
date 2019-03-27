using Hinojosa.RepositorioDocumentos;
using Hinojosa.RepositorioDocumentos.Laserfiche;
using InternetReports.Areas.Operacion.Models;
using InternetReports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using InternetReports.AppExtensions;
using Hinojosa.Utilities.Autenticacion;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;
using RecoVfpLib = Hinojosa.RECOVFP.DataAccessLayer;
namespace InternetReports.Areas.Operacion.Controllers
{
    public class DescargaExpedientesController : Controller
    {
        public IARCHIVOS_ALT _catalogos;
        public IBuscadorDocumentos<DocumentoRepositorio> buscadorRepositorio;
        protected RepositoriosFactory RepositorioDocumentosFactory { get; set; }

        public DescargaExpedientesController()
        {
            RepositorioDocumentosFactory = new RepositoriosFactory();
            _catalogos = new ARCHIVOS_ALTFactory().Create();
            
        }

        // GET: Operacion/DescargaExpedientes
        public ActionResult Index()
        {
            BusquedaExpedienteViewModel datosBusqueda = new BusquedaExpedienteViewModel();
            return View(datosBusqueda);
        }

        // GET: Operacion/DescargaExpedientes/ListadoExpediente/....
        public async Task<ActionResult> ListadoExpediente(BusquedaExpedienteViewModel datosBusqueda)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("BúsquedaErronea", "Los parámetros de búsqueda no son correctos");
                return View("Index");
            }

            //La aduana puede ser aduana o aduana/seccion. Para motivos de consulta se separa la aduana de la seccion
            if (datosBusqueda != null && !string.IsNullOrEmpty(datosBusqueda.Aduana) && datosBusqueda.Aduana.Length > 2)
            {
                datosBusqueda.Aduana = datosBusqueda.Aduana.Substring(0, 2);
            }

             
             

            /*1. Verificamos si se está buscando por referencia o por pedimento. En caso de no contener la referencia,
            * se realiza la búsqueda por pedimento, aduana y año. Sino vienen estos datos, la búsqueda no aplica.
            **/
            List<PedimentosSaaiSirView> pedimentos = null;
            if (string.IsNullOrEmpty(datosBusqueda.Referencia))
            {
                if (string.IsNullOrEmpty(datosBusqueda.Aduana) || string.IsNullOrEmpty(datosBusqueda.Año) || string.IsNullOrEmpty(datosBusqueda.Pedimento))
                {
                    ModelState.AddModelError("InformacionIncompletaBusqueda", "Se requiere establecer parámetros de búsqueda por referencia o por pedimento inlcuyendo el año y la aduana");
                    return View("Index");

                }

                DateTime fechaInicioBusqueda = Convert.ToDateTime($"01/01/{datosBusqueda.Año}"), fechaFinBusqueda = Convert.ToDateTime($"31/12/{datosBusqueda.Año}");

                pedimentos = _catalogos.PedimentosSaaiSirViews.AsNoTracking().Where(f => f.Aduana == datosBusqueda.Aduana && f.FechaPago > fechaInicioBusqueda && f.FechaPago < fechaFinBusqueda && f.Pedimento == datosBusqueda.Pedimento).ToList();
            }
            else
            {
                pedimentos = _catalogos.PedimentosSaaiSirViews.AsNoTracking().Where(f => f.Referencia == datosBusqueda.Referencia).ToList();
            }

            PedimentosSaaiSirView pedimento = pedimentos.FirstOrDefault(f => f.IdClienteC.Value.ToString() == User.Identity.GetClientId());

            //Si no se encontro en SQL (del 2017 hacia atrás) buscar en el histórico del SAAI VFP
            if (pedimento == null)
            {
                pedimento = await BuscarPedimentoSAAI(datosBusqueda, pedimento);
            }

            //1.1 Seguridad: Verificar que el usuario tenga acceso a este pedimento mediante el cliente
            //TODO: Verificar cuando un usuario tenga varios clientes
            if (pedimento == null || (!User.IsInRole("Administrador") && pedimento.IdClienteP.Value.ToString() != User.Identity.GetClientId()))
            {
                ModelState.AddModelError("PedimentoNoEncontrado", "No se encontró el pedimento o la referencia requerida");
                return View("Index");
                //return new HttpStatusCodeResult(403); //Forbidden
            }


            //2. Se realiza la búsqueda de los documentos del expediente con la interfaz correcta
            using (Impersonator impersonator = new Impersonator("dah.programador01", "AD-HINOJOSA", "Hinojosa2018"))
            {
                using (Laserfiche.RepositoryAccess.Session sesion = Laserfiche.RepositoryAccess.Session.Create("SERVERWA", "DA-HINOJOSA"))
                {
                    buscadorRepositorio = RepositorioDocumentosFactory.CrearBuscador(Repositorio.Laserfiche, sesion);

                    //await buscadorRepositorio.OpenAsync();
                    IEnumerable<DocumentoRepositorio> carpetaReferenciaEnumerable = await buscadorRepositorio.BuscarDocumentosExpedienteAsync(new string[] { pedimento.Referencia }, null);
                    DocumentoRepositorio[] documentosRepositorio = carpetaReferenciaEnumerable.ToArray();

                    //IEnumerable<DocumentoRepositorio> documentos = await documentosRepositorio[0].ExtraerDocumentosAsync(sesion);

                    //3. Se agrega el listado de documentos a la vista
                    datosBusqueda.ArchivosExpediente = documentosRepositorio.Select(documento => new ArchivoExpedienteViewModel()
                    {
                        Nombre = documento.Nombre,
                        Identificador = documento.IdDocumento,
                        Seleccionado = false,
                        SistemaId = documento.Repositorio.ToString()
                    }).ToList();

                    buscadorRepositorio.Close();
                }
            }

            datosBusqueda.Aduana = datosBusqueda.Aduana ?? pedimento.Aduana;
            datosBusqueda.Año = datosBusqueda.Año ?? pedimento.FechaPago.Value.Year.ToString();
            datosBusqueda.Pedimento = datosBusqueda.Pedimento ?? pedimento.Pedimento;
            datosBusqueda.Referencia = datosBusqueda.Referencia ?? pedimento.Referencia;

            return View("Index", datosBusqueda);
        }

        private static async Task<PedimentosSaaiSirView> BuscarPedimentoSAAI(BusquedaExpedienteViewModel datosBusqueda, PedimentosSaaiSirView pedimento)
        {
            if (pedimento == null)
            {
                List<RecoVfpLib.Entidades.SAAI.Ssdagi01Entity> listaImpos = null;
                List<RecoVfpLib.Entidades.SAAI.Ssdage01Entity> listaExpos = null;
                RecoVfpLib.Repositorios.SAAI.ISsdagi01 repositorio = new RecoVfpLib.Repositorios.SAAI.Ssdagi01RepositorioODBC();
                RecoVfpLib.Repositorios.SAAI.ISsdage01 repositorioExpo = new RecoVfpLib.Repositorios.SAAI.Ssdage01RepositorioODBC();

                //Se verifica si la referencia es de Altamira, Reynosa o Matamoros
                Regex referenciaAltamiraRegex = new Regex(@"[MR]?\d{7}\-[\w\d]{2}");
                if (!string.IsNullOrEmpty(datosBusqueda.Referencia) && referenciaAltamiraRegex.IsMatch(datosBusqueda.Referencia))
                {

                    listaImpos = await repositorio.RecuperarPorReferenciaAsync(datosBusqueda.Referencia);

                }
                else if (!string.IsNullOrEmpty(datosBusqueda.Pedimento) && !string.IsNullOrEmpty(datosBusqueda.Año) && !string.IsNullOrEmpty(datosBusqueda.Aduana))
                {
                    listaImpos = await repositorio.RecuperarPorPedimentoAñoAduanaAsync(datosBusqueda.Pedimento, Convert.ToInt32(datosBusqueda.Año), Convert.ToInt32(datosBusqueda.Aduana));
                }

                if (listaImpos != null && listaImpos.Any())
                {

                    pedimento = listaImpos.Select(s => new PedimentosSaaiSirView()
                    {
                        Pedimento = s.Numped01,
                        Referencia = s.Refcia01,
                        Aduana = s.Cveadu01,
                        Operacion = Convert.ToByte(s.Tipopr01),
                        Sistema = "SAAI",
                        FechaPago = s.Fecpag01,
                        Patente = s.Cveade01,
                        IdClienteP = Convert.ToInt32(s.Cvecli01),
                        IdClienteC = Convert.ToInt32(s.Cvecli01),
                        Clave = s.Cveped01,
                        Seccion = s.Cvesec01,
                        Cliente = s.Nomcli01
                    }).FirstOrDefault();

                    return pedimento;
                }

                //Buscamos en expo
                if(pedimento == null)
                {
                    if (!string.IsNullOrEmpty(datosBusqueda.Referencia) && referenciaAltamiraRegex.IsMatch(datosBusqueda.Referencia))
                    {

                        listaExpos = await repositorioExpo.RecuperarPorReferenciaAsync(datosBusqueda.Referencia);

                    }
                    else if (!string.IsNullOrEmpty(datosBusqueda.Pedimento) && !string.IsNullOrEmpty(datosBusqueda.Año) && !string.IsNullOrEmpty(datosBusqueda.Aduana))
                    {
                        listaExpos = await repositorioExpo.RecuperarPorPedimentoAñoAduanaAsync(datosBusqueda.Pedimento, Convert.ToInt32(datosBusqueda.Año), Convert.ToInt32(datosBusqueda.Aduana));
                    }

                    if (listaExpos != null && listaExpos.Any())
                    {

                        pedimento = listaExpos.Select(s => new PedimentosSaaiSirView()
                        {
                            Pedimento = s.Numped01,
                            Referencia = s.Refcia01,
                            Aduana = s.Cveadu01,
                            Operacion = Convert.ToByte(s.Tipopr01),
                            Sistema = "SAAI",
                            FechaPago = s.Fecpag01,
                            Patente = s.Cveade01,
                            IdClienteP = Convert.ToInt32(s.Cvecli01),
                            IdClienteC = Convert.ToInt32(s.Cvecli01),
                            Clave = s.Cveped01,
                            Seccion = s.Cvesec01,
                            Cliente = s.Nomcli01
                        }).FirstOrDefault();

                        return pedimento;
                    }
                }
            }

            return pedimento;
        }

        public async Task<ActionResult> Descarga(BusquedaExpedienteViewModel datosDescarga)
        {
            IExportadorDocumentos<DocumentoRepositorio> exportadorRepositorio = null;
            IOperacionesRepositorio<DocumentoRepositorio> operacionesRepositorio = null;

            if (datosDescarga.ArchivosExpediente != null && datosDescarga.ArchivosExpediente.Count > 0)
            {
                //1. Nos conectamos al repositorio y bajamos los documentos especificados
                //Impersonado para Laserfiche
                using (Impersonator impersonator = new Impersonator("dah.programador01", "AD-HINOJOSA", "Hinojosa2018"))
                {
                    using (Laserfiche.RepositoryAccess.Session sesion = Laserfiche.RepositoryAccess.Session.Create("SERVERWA", "DA-HINOJOSA"))
                    {

                        exportadorRepositorio = RepositorioDocumentosFactory.CrearExportador(Repositorio.Laserfiche, sesion);
                        operacionesRepositorio = RepositorioDocumentosFactory.CrearOperaciones(Repositorio.Laserfiche, sesion);
                        DocumentoRepositorio[] listaDocumentos = datosDescarga.ArchivosExpediente.Where(w => w.Seleccionado).Select(s => operacionesRepositorio.ObtenerArchivoPorId(s.Identificador)).ToArray();
                        
                        
                        Guid temporalGuid = Guid.NewGuid();

                        

                        string rutaTemporal = Server.MapPath("~/" +ConfigurationManager.AppSettings["RutaTemporalDescargas"] + temporalGuid.ToString());
                        Directory.CreateDirectory(rutaTemporal);

                        await exportadorRepositorio.ExportarAsync(listaDocumentos, rutaTemporal, true);

                        //Borrar los archivos temporales después de descargar
                        var fileInfo = new FileInfo($"{rutaTemporal}.zip");
                        long byteSize = fileInfo.Length;
                        byte[] fileByteArray = new byte[byteSize];

                        fileByteArray = System.IO.File.ReadAllBytes($"{rutaTemporal}.zip");

                        System.IO.File.Delete($"{rutaTemporal}.zip");
                        System.IO.Directory.Delete($"{rutaTemporal}",true);

                        //Se obtienen datos de pedimento
                        PedimentosSaaiSirView pedimento = null;
                        if (!string.IsNullOrEmpty(datosDescarga.Referencia))
                        {
                            pedimento = _catalogos.PedimentosSaaiSirViews.FirstOrDefault(f => f.Referencia == datosDescarga.Referencia);
                            pedimento = pedimento ?? await BuscarPedimentoSAAI(datosDescarga, pedimento);
                            if (pedimento != null)
                            {
                                datosDescarga.Aduana = datosDescarga.Aduana ?? pedimento.Aduana;
                                datosDescarga.Año = datosDescarga.Año ?? pedimento.FechaPago.Value.Year.ToString();
                                datosDescarga.Pedimento = datosDescarga.Pedimento ?? pedimento.Pedimento;
                                datosDescarga.Referencia = datosDescarga.Referencia ?? pedimento.Referencia;
                            }
                            
                        }

                        return File(fileByteArray, "application/zip", $"{datosDescarga.Año.Substring(2,2)} {datosDescarga.Aduana} {datosDescarga.Pedimento}.zip");
                    }
                }
            }

            return HttpNotFound();
            
        }


        //// GET: Operacion/DescargaExpedientes/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Operacion/DescargaExpedientes/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Operacion/DescargaExpedientes/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Operacion/DescargaExpedientes/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Operacion/DescargaExpedientes/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Operacion/DescargaExpedientes/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
