using InternetReports.Areas.Reportes.Models;
using Reports.DAL;
using Reports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using InternetReports.AppExtensions;
using InternetReports.Models;
using Microsoft.AspNet.Identity.Owin;
using Newtonsoft.Json;
using System.Data.SqlClient;
using Hinojosa.Common.DataAccessLayer.Repositorios;

namespace InternetReports.Areas.Reportes.Controllers
{
    [Authorize]
    public class OperacionesController : Controller
    {
        private string _clienteId;
        private string _nombreCliente;
        protected AppUserManager _userManager;
        protected SitioClientesHinojosaDbContext ReportesDb = new SitioClientesHinojosaDbContext();

        //Este contexto de EnttyFramework se declara como estático para aprovechar el uso del cache de objetos de entity framwork
        private static ARCHIVOS_ALT _catalogos;
        protected ClientesRepositorio Catalogos
        {
            //get
            //{
            //    _catalogos  = _catalogos ??  new ARCHIVOS_ALT();
            //    return _catalogos;
            //}
            get
            {
                return Repositorio;
            }
        }

        ClientesRepositorio repositorio;
        ClientesRepositorio Repositorio
        {
            get
            {
                repositorio = repositorio ?? new ClientesRepositorio();
                return repositorio;
            }
        }


        public AppUserManager UserManager
        {
            get
            {
                _userManager = _userManager ?? HttpContext.GetOwinContext().Get<AppUserManager>();
                return _userManager;
            }
            private set
            {
                _userManager = value;
            }
        }

        public string ClienteId
        {
            get
            {
                _clienteId = _clienteId ?? User.Identity.GetClientId();
                return _clienteId;
            }
            set
            {
                _clienteId = value;
            }
        }
        public string NombreCliente
        {
            get
            {
                _nombreCliente = _nombreCliente ?? User.Identity.GetNombreCliente();
                return _nombreCliente;

            }
            set { _nombreCliente = value; }
        }

        public OperacionesController()
        {
            
        }

        // GET: Reportes/Operaciones
        [HttpGet]
        public async Task<ActionResult> Index(DateTime? startDate = null, DateTime? endDate=null, string clienteId = null)
        {
            //Por default se muestra la fecha anterior
            //startDate = startDate ?? DateTime.Now.AddDays(-1).Date;
            //endDate = endDate ?? DateTime.Now.AddDays(-1).Date;

            //En caso de que el usuario no sea administrador se establece el clienteId con el id del cliente logueado
            if (User.IsInRole("Administrador"))
            {
                clienteId = clienteId ?? "0";
                int idClienteNumero = Convert.ToInt32(clienteId);
                ViewBag.NombreCliente = await Catalogos.RecuperarPorId(idClienteNumero.ToString());
                    
            }
            else
            {
                clienteId = ClienteId;
                ViewBag.NombreCliente = NombreCliente;
            }
                        
            
            //En el caso de que el rol sea administrador hay que cargar los clientes en la vista
            if (User.IsInRole("Administrador"))
            {
                //Catalogos.Configuration.AutoDetectChangesEnabled = false;
                
                ViewBag.CatalogoClientes = new SelectList((await Catalogos.Recuperar()).Select(s => new {IdCli = s.IdCli, Nom1 = s.Nom1 }).OrderBy(o => o.Nom1).ToList(),"IdCli","Nom1");
            }

            IEnumerable<Partida> resultados = new List<Partida>();

            if (startDate != null && endDate != null)
            {
                //Busqueda de resultados
                var Resultados = new MabeReportSource(clienteId, startDate.Value, endDate.Value);
                resultados = await Resultados.GetReportAsync();

                var referencias = resultados.Select(s => "'" + s.Referencia + "'");
                string referenciascadena = "";
                string consultaObservaciones = "SELECT * FROM EdicionesReportes WHERE ReporteId = 'Operaciones' AND Campo='Observaciones' AND ClienteId = @ClienteId ";
                string consultaFechasDeSalidaEditadas = "SELECT * FROM EdicionesReportes WHERE ReporteId = 'Operaciones' AND Campo='FechaSalida' AND ClienteId = @ClienteId ";

                if (referencias.Count() > 0)
                {
                    referenciascadena = referencias.Aggregate((previo, siguiente) => previo + "," + siguiente);


                    //Se agregan las observaciones
                    consultaObservaciones += " AND IdentificadorRegistro IN(" + referenciascadena + ")";

                    var observaciones = ReportesDb.ObservacionesReportes//.Where(o => o.ClienteId == clienteId && referencias.Any(a=> a == o.IdentificadorRegistro) )
                        .SqlQuery(consultaObservaciones, new SqlParameter("@ClienteId", clienteId))
                        .ToArray();

                    if (observaciones != null && observaciones.Count() > 0)
                    {
                        resultados = resultados.GroupJoin(observaciones, itemReporte => itemReporte.Referencia, itemObservaciones => itemObservaciones.IdentificadorRegistro, (itemReporte, observacionesList) =>
                        {
                            var observacion = observacionesList.FirstOrDefault();
                            if (observacion != null)
                            {
                                itemReporte.Observaciones = observacion.Valor;
                            }

                            return itemReporte;
                        });
                    }

                    //Se agregan las fechas de salida editadas
                    consultaFechasDeSalidaEditadas += " AND IdentificadorRegistro IN(" + referenciascadena + ")";

                    var fechasDeSalidas = ReportesDb.ObservacionesReportes//.Where(o => o.ClienteId == clienteId && referencias.Any(a=> a == o.IdentificadorRegistro) )
                        .SqlQuery(consultaFechasDeSalidaEditadas, new SqlParameter("@ClienteId", clienteId))
                        .ToArray();

                    if (fechasDeSalidas != null && fechasDeSalidas.Count() > 0)
                    {
                        resultados = resultados.GroupJoin(fechasDeSalidas, itemReporte => itemReporte.Referencia, itemFechaDeSalidaEditada => itemFechaDeSalidaEditada.IdentificadorRegistro, (itemReporte, fechaDeSalidaList) =>
                        {
                            var fechaSalidaItem = fechaDeSalidaList.FirstOrDefault();
                            if (fechaSalidaItem != null)
                            {
                                itemReporte.FechaSalida = (DateTime?)Convert.ChangeType(fechaSalidaItem.Valor, Type.GetType(fechaSalidaItem.TipoNet));
                            }

                            return itemReporte;
                        });
                    }
                }
            }
            
            return View(resultados);
            
        }



        // GET: Reportes/Operaciones/Editar/:clienteId/:referencia
        [HttpGet]
        public async Task<ActionResult> Editar(string clienteId, string referencia)
        {
            List<EdicionReporte> edicionesReporte = ReportesDb.ObservacionesReportes.Where(f => f.IdentificadorRegistro == referencia && f.ClienteId == clienteId).ToList();
            EdicionReporte observacionReporte = edicionesReporte.FirstOrDefault(f => f.Campo == "Observaciones");
            EdicionReporte fechaSalidaReporte = edicionesReporte.FirstOrDefault(f => f.Campo == "FechaSalida");

            OperacionViewModel operacionViewModel = new OperacionViewModel()
            {
                ObservacionesId = observacionReporte != null ? observacionReporte.EdicionId : 0,
                Referencia = referencia,
                ClienteId = clienteId,
                Observaciones = observacionReporte != null ? observacionReporte.Valor : "",
                FechaSalidaId = fechaSalidaReporte != null ? fechaSalidaReporte.EdicionId : 0,
                FechaSalida = fechaSalidaReporte != null ? (DateTime?)Convert.ChangeType(fechaSalidaReporte.Valor, Type.GetType(fechaSalidaReporte.TipoNet)) : null
            };

            

            return View(operacionViewModel);
        }

        // POST: Reportes/Operaciones/Editar
        [HttpPost]
        public async Task<ActionResult> Editar(OperacionViewModel operacionViewModel)
        {
            if (ModelState.IsValid)
            {

                //Observaciones
                if (operacionViewModel.ObservacionesId > 0)
                {
                    EdicionReporte observacionItem = ReportesDb.ObservacionesReportes.Find(operacionViewModel.ObservacionesId);
                    observacionItem.Valor = operacionViewModel.Observaciones;
                }
                else if(!string.IsNullOrEmpty(operacionViewModel.Observaciones))
                {
                    EdicionReporte observacionItem = new EdicionReporte()
                    {
                        Valor = operacionViewModel.Observaciones,
                        IdentificadorRegistro = operacionViewModel.Referencia,
                        ReporteId = "Operaciones",
                        ClienteId = operacionViewModel.ClienteId,
                        Campo = "Observaciones",
                        TipoNet = typeof(String).ToString(),
                        TipoSql = System.Data.SqlDbType.VarChar.ToString()
                    };

                    ReportesDb.ObservacionesReportes.Add(observacionItem);
                }

                //Fecha de salida
                if (operacionViewModel.FechaSalidaId > 0)
                {
                    EdicionReporte observacionItem = ReportesDb.ObservacionesReportes.Find(operacionViewModel.FechaSalidaId);
                    observacionItem.Valor = operacionViewModel.FechaSalida.ToString();
                }
                else if(operacionViewModel.FechaSalida.HasValue)
                {
                    EdicionReporte observacionItem = new EdicionReporte()
                    {
                        Valor = operacionViewModel.FechaSalida.ToString(),
                        IdentificadorRegistro = operacionViewModel.Referencia,
                        ReporteId = "Operaciones",
                        ClienteId = operacionViewModel.ClienteId,
                        Campo = "FechaSalida",
                        TipoNet = typeof(DateTime).ToString(),
                        TipoSql = System.Data.SqlDbType.DateTime2.ToString()
                    };

                    ReportesDb.ObservacionesReportes.Add(observacionItem);
                }

                await ReportesDb.SaveChangesAsync();
            }
            else
            {
                return View(operacionViewModel);
            }

            return View("Cerrar", operacionViewModel);
        }



        //// GET: Reportes/Operaciones/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Reportes/Operaciones/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Reportes/Operaciones/Create
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

        //// GET: Reportes/Operaciones/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Reportes/Operaciones/Edit/5
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

        //// GET: Reportes/Operaciones/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Reportes/Operaciones/Delete/5
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
