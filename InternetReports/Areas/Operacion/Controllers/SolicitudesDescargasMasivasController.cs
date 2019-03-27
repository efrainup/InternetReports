using InternetReports.Areas.Operacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InternetReports.AppExtensions;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Messaging;

namespace InternetReports.Areas.Operacion.Controllers
{
    [Authorize]
    public class SolicitudesDescargasMasivasController : Controller
    {
        protected SitioClientesHinojosaDbContext dbContext = new SitioClientesHinojosaDbContext();
        public MessageQueue ColaDeSolicitudes = new MessageQueue(".\\private$\\hin_solicitudesdescargaexpedientes");

        // GET: Operacion/SolicitudesDescargasMasivas
        public ActionResult Index()
        {
            string clienteId = User.Identity.GetClientId();
            return View(dbContext.DescargasMasivas.Where(w=> w.IdCliente == clienteId).ToArray());
        }

        // GET: Operacion/SolicitudesDescargasMasivas/Descargar/SDM-XXX-yyyyMMdd-XX
        public async Task<ActionResult> Descargar(string folioDescarga)
        {
            SolicitudDescargaMasiva solicitud = dbContext.DescargasMasivas.FirstOrDefault(f => f.NombreSolicitud == folioDescarga);

            if(solicitud != null)
            {
                if(User.Identity.GetClientId() == solicitud.IdCliente)
                {
                    return File(solicitud.RutaArchivo, "application/x-rar-compressed",solicitud.NombreSolicitud + ".rar");
                }
                else
                {
                    return View();
                }

            }

            return View();

        }

        // GET: Operacion/SolicitudesDescargasMasivas/NuevaSolicitud
        [HttpGet]
        public ActionResult NuevaSolicitud()
        {
            return View();
        }

        // POST: Operacion/SolicitudesDescargasMasivas/NuevaSolicitud
        [HttpPost]
        public async Task<ActionResult> NuevaSolicitud(SolicitudDescargaMasivaViewModel solicitudDescargaMasiva)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var solicitud = new SolicitudDescargaMasiva()
                    {
                        IdCliente = User.Identity.GetClientId(),
                        Cliente = User.Identity.GetNombreCliente(),
                        FechaInicio = solicitudDescargaMasiva.FechaInicio,
                        FechaFin = solicitudDescargaMasiva.FechaFin,
                        Descripcion = solicitudDescargaMasiva.Descripcion,
                        FechaSolicitud = DateTime.Now,
                        Notificar=solicitudDescargaMasiva.Notificar,
                        NombreSolicitud="SDM-"+ User.Identity.GetClientId()+"-" + DateTime.Now.ToString("yyyyMMdd-hhmmss")
                    };

                    dbContext.DescargasMasivas.Add(solicitud);
                    await dbContext.SaveChangesAsync();

                    //var formatter = new XmlMessageFormatter(new Type[] { typeof(string) });

                    //Message m = new Message();
                    //m.Formatter = formatter;
                    //m.Body = solicitud;
                    //ColaDeSolicitudes.Formatter = formatter;
                    
                    //ColaDeSolicitudes.Send(solicitud);
                }

                return RedirectToAction("Index");
            }
            catch (DbEntityValidationException excepcionValidacion)
            {
                string Mensaje = "";
                foreach (DbEntityValidationResult validacion in excepcionValidacion.EntityValidationErrors)
                {

                    foreach (DbValidationError errorvalidacion in validacion.ValidationErrors)
                    {
                        ModelState.AddModelError(errorvalidacion.PropertyName, errorvalidacion.ErrorMessage);
                        //this.Controls[0].DataBindings.Add()
                    }

                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error_key_" + DateTime.Now.Ticks, e.Message);
            }
            return View();
        }

    }
}
