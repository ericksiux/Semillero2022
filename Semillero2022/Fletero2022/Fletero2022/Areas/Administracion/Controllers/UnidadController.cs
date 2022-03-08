using Fletero.Administracion.Services.Contracs.Manager;
using Fletero.Administracion.Services.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fletero2022.Areas.Administracion.Controllers
{
    public class UnidadController : Controller
    {
        // GET: Administracion/Unidad
        public ActionResult Index()
        {
            IUnidadManager manager = new UnidadManager();

            var datosLista = manager.ObtenerUnidadList();

            return View();
        }

        // GET: Administracion/Unidad/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Administracion/Unidad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administracion/Unidad/Create
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

        // GET: Administracion/Unidad/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Administracion/Unidad/Edit/5
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

        // GET: Administracion/Unidad/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administracion/Unidad/Delete/5
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
