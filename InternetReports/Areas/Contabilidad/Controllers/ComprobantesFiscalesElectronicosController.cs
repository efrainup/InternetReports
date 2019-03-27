using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using InternetReports.AppExtensions;
using ModelosRaiz = InternetReports.Models;

namespace InternetReports.Areas.Contabilidad.Controllers
{
    [Authorize]
    public class ComprobantesFiscalesElectronicosController : Controller
    {
        public ModelosRaiz.IARCHIVOS_ALT Contexto { get; set; }

        public ComprobantesFiscalesElectronicosController()
        {
            var factory = new ModelosRaiz.ARCHIVOS_ALTFactory();
            Contexto = factory.Create();
        }

        // GET: Contabilidad/ComprobantesFiscalesElectronicos
        public async Task<ActionResult> Index(DateTime? fecha_inicio = null, DateTime? fecha_fin = null, string cuenta_de_gastos = null ,int? IdCliente = null)
        {
            string serie = null;
            string folio = null;

            

            //Si no es administrador no puede buscar por otro IdCliente
            if (!User.IsInRole("Administrador"))
            {
                IdCliente = Convert.ToInt32(User.Identity.GetClientId());
            }

            //Si la cuenta de gastos no está vacía entonces se separa en serie y folio
            if (!string.IsNullOrEmpty(cuenta_de_gastos))
            {
                Regex regex = new Regex(@"(\w+?)(\d+)");
                GroupCollection grupos = regex.Match(cuenta_de_gastos).Groups;

                //El grupo 0 corresponde a la match completo ALTAM1030122
                serie = grupos[1].Value; //Coresponde al subgrupo 1 ALTAM
                folio = grupos[2].Value; //Subgrupo 2 1030122
            }
            //En caso que no se este buscando por cuenta de gastos, se debe especificar un fecha par ala busqueda
            else if (!fecha_inicio.HasValue || !fecha_fin.HasValue) 
            {
                return View(new ModelosRaiz.UspRecuperarComplementosDePagoPorClienteReturnModel[0]);
            }

            IEnumerable<ModelosRaiz.UspRecuperarComplementosDePagoPorClienteReturnModel> resultado = await Contexto.UspRecuperarComplementosDePagoPorClienteAsync(IdCliente, fecha_inicio, fecha_fin,null,serie,folio);

            return View(resultado);
        }

        // GET: Contabilidad/ComprobantesFiscalesElectronicos/Descargar/COB_DIN050603R49_DIN050603_22371%20-%201
        public async Task<ActionResult> Descargar(int id)
        {
            int? IdCliente = null;

            //Si no es administrador no puede buscar por otro IdCliente
            if (!User.IsInRole("Administrador"))
            {
                IdCliente = Convert.ToInt32(User.Identity.GetClientId());
            }

            IEnumerable<ModelosRaiz.UspRecuperarComplementosDePagoPorClienteReturnModel> resultados = await Contexto.UspRecuperarComplementosDePagoPorClienteAsync(IdCliente, null, null, id,null,null);

            string rutaDescargas = Server.MapPath("~/" + ConfigurationManager.AppSettings["RutaTemporalDescargas"]);


            foreach (ModelosRaiz.UspRecuperarComplementosDePagoPorClienteReturnModel resultado in resultados)
            {
                string nombreSInExtension = resultado.Archivo.Substring(0, resultado.Archivo.Length - 4);
                string rutaTemporalDescargas = rutaDescargas +"\\"+ nombreSInExtension ;
                
                //Crear carpeta temporal
                Directory.CreateDirectory(rutaTemporalDescargas);

                //Se copian a temporales el xml y el pdf
                System.IO.File.Copy(resultado.Ruta +  nombreSInExtension + ".pdf", rutaTemporalDescargas+ "\\" +  nombreSInExtension + ".pdf");
                System.IO.File.Copy(resultado.Ruta +  nombreSInExtension + ".xml", rutaTemporalDescargas + "\\" + nombreSInExtension + ".xml");

                //Se zippea
                ZipFile.CreateFromDirectory(rutaTemporalDescargas, rutaDescargas + "\\" + nombreSInExtension + ".zip");

                byte[] zipBytes = System.IO.File.ReadAllBytes(rutaTemporalDescargas + ".zip");
                System.IO.File.Delete(rutaTemporalDescargas + ".zip");
                System.IO.Directory.Delete(rutaTemporalDescargas,true);
                return File(zipBytes, "application/zip", nombreSInExtension + ".zip");
            }


            return HttpNotFound();
        }

        
    }
}
