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

namespace InternetReports.Areas.Reportes.Controllers
{
    [Authorize]
    public class OperacionesController : Controller
    {
        private string _clienteId;
        private string _nombreCliente;
        protected AppUserManager _userManager;

        protected ARCHIVOS_ALT Catalogos = new ARCHIVOS_ALT();
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
            startDate = startDate ?? DateTime.Now.AddDays(-1).Date;
            endDate = endDate ?? DateTime.Now.AddDays(-1).Date;

            //En caso de que el usuario no sea administrador se establece el clienteId con el id del cliente logueado
            if (User.IsInRole("Administrador"))
            {
                clienteId = clienteId ?? "0";
                int idClienteNumero = Convert.ToInt32(clienteId);
                ViewBag.NombreCliente = Catalogos.CatClientes.Where(w => w.IdCli == idClienteNumero).Take(1).FirstOrDefault().Nom1;
            }
            else
            {
                clienteId = ClienteId;
                ViewBag.NombreCliente = NombreCliente;
            }
                        
            
            //En el caso de que el rol sea administrador hay que cargar los clientes en la vista
            if (User.IsInRole("Administrador"))
            {
                ViewBag.CatalogoClientes = new SelectList(Catalogos.CatClientes.ToArray(),"IdCli","Nom1");
            }

            //Busqueda de resultados
            var Resultados = new MabeReportSource<Partida>(clienteId, startDate.Value, endDate.Value);

            return View(await Resultados.GetReportAsync());
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
