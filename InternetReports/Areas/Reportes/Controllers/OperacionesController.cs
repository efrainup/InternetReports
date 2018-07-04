using InternetReports.Areas.Reportes.Models;
using Reports.DAL;
using Reports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace InternetReports.Areas.Reportes.Controllers
{
    [Authorize]
    public class OperacionesController : Controller
    {
        // GET: Reportes/Operaciones
        public async Task<ActionResult> Index(DateTime? startDate = null, DateTime? endDate=null)
        {
            startDate = startDate ?? DateTime.Now.AddDays(-1).Date;
            endDate = endDate ?? DateTime.Now.AddDays(-1).Date;

            var r = new MabeReportSource<Partida>("590", startDate.Value, endDate.Value);
            return View(await r.GetReportAsync());
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
