﻿using Fletero.Administracion.Services.Contracs.DTO;
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
    public class UnidadController : Controller
    {
        // GET: Administracion/Unidad
        public ActionResult Index()
        {
            UnidadModel model = new UnidadModel();
            IDistritoManager manager = new DistritoManager();
            model.Districts = manager.ObtenerDistritos();

            ITiendaManager managerT = new TiendaManager();
            model.Stores = managerT.ObtenerTiendas(0);

            IFleteroManager managerF = new FleteroManager();
            model.TodosFleteros = managerF.ObtenerFleteroInfoGeneral();

            return View(model);
        }
        public ActionResult AgregarUnidad()
        {
            UnidadModel model = new UnidadModel();
            ITiendaManager managerT = new TiendaManager();
            model.Stores = managerT.ObtenerTiendas(0);

            IFleteroManager managerF = new FleteroManager();
            model.TodosFleteros = managerF.ObtenerFleteroInfoGeneral();

            ITipoUnidadManager managerTU = new TipoUnidadManager();
            model.TipoDeUnidad = managerTU.ObtenerTipoUnidad(0);

            ITipoCarroceriaManager managerTC = new TipoCarroceriaManager();
            model.TipoDeCarroceria = managerTC.ObtenerTipoCarroceria(0);

            IUnidadManager manager = new UnidadManager();

            var datosLista = manager.ObtenerUnidadList();

            return View(model);
        }

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GuardarUnidad(UnidadModel unidadParam)
        {
            try
            {
                IUnidadManager manager = new UnidadManager();
                var unidadDTO = new UnidadCargaDTO();
                unidadDTO.Fletero = unidadParam.Fletero;
                unidadDTO.TipoUnidad = unidadParam.TipoUnidad;
                var UnidadID = manager.RegistrarUnidad(unidadDTO);

                return Json(new { Succes = 1, Value = UnidadID }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Succes = 0, Data = ex }, JsonRequestBehavior.AllowGet);
            }
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
