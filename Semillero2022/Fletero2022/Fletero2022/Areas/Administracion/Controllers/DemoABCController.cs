using Fletero.Administracion.Services.Contracs.DTO;
using Fletero.Administracion.Services.Contracs.Manager;
using Fletero.Administracion.Services.Manager;
using Fletero2022.Areas.Administracion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fletero2022.Areas.Administracion.Controllers
{

    //DemoABC creado con la opcion MVC5 Controller with read/write actions
    public class DemoABCController : Controller
    {
        // GET: Administracion/DemoABC
        public ActionResult Index()
        {
            DemoABCModel modelo = new DemoABCModel();
            IDemoManager manager = new DemoManager();

            var ModeloAbc = new DemoDTO();

            ModeloAbc.Campo2 = "Campo2";
            ModeloAbc.Campo3 = new List<string> { "Detalle 1", " Detalle 2", "Detalle 3" };
            ModeloAbc.Campo4 = true;

            var IdCreado = manager.Guardar(ModeloAbc);


            var DemoList = manager.ObtenerDemoList();

            return View(modelo);
        }

        // GET: Administracion/DemoABC/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Administracion/DemoABC/Create
        public ActionResult Create()
        {
            IDemoManager manager = new DemoManager();
            DemoDTO objetoGuardar = new DemoDTO { CampoID = 1, Campo2 = "Valor 2" };
            var IdCreado = manager.Guardar(objetoGuardar);

            return View();
        }


        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GuardarDemo(DemoABCModel demoParam)
        {
            try
            {
                IDemoManager manager = new DemoManager();

                var demoDTO = new DemoDTO();
                demoDTO.CampoID = demoParam.Campo1;
                demoDTO.Campo2 = demoParam.Campo2;
                demoDTO.Campo4 = demoParam.Campo4;

                var DemoID = manager.Guardar(demoDTO);

                return Json(new { Success = 1 , Value = DemoID }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Success = 0, Data = ex }, JsonRequestBehavior.AllowGet);
            }
        }

        // POST: Administracion/DemoABC/Create
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

        // GET: Administracion/DemoABC/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Administracion/DemoABC/Edit/5
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

        // GET: Administracion/DemoABC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administracion/DemoABC/Delete/5
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
