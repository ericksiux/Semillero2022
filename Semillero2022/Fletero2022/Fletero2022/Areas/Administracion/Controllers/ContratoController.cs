using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fletero2022.Areas.Administracion.Controllers
{
    public class ContratoController : Controller
    {
        // GET: Administracion/Contrato
        public ActionResult Index()
        {
            return View();
        }

        // GET: Administracion/Contrato/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Administracion/Contrato/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administracion/Contrato/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administracion/Contrato/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Administracion/Contrato/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administracion/Contrato/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administracion/Contrato/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
