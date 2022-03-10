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
    public class OperadorController : Controller
    {
        // GET: Administracion/Operador
        public ActionResult Index()

        {
            OperadorModel modelo = new OperadorModel();
            IOperadorManager manager = new OperadorManager();


            var DemoList = manager.ObtenerOperadorList();

            return View(modelo);
        }

        // GET: Administracion/Operador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Administracion/Operador/Create
        public ActionResult Create()
        {
            IOperadorManager manager = new OperadorManager();
            OperadorDTO objetoGuardar = new OperadorDTO {
                distrito = 30,
                fletero = 4,
                unidad = 2,
                nombre = "juan",
                apellidoPat = "perez",
                apellidoMAt = "castro",
                calle = "de las aves",
                numero = 234,
                colonia = "v",
                municipio = "culiacan",
                estado = "sinaloa",
                cp = 27,
                @noCredencialElector = 876,
                fechaVigenciaLicencia = "02-01-2023",
                noLicencia = 765,
                padecimientos = null,
                curp = "jhhsjhd865",
                noIMSS = 8877,
                estatusConfiabilidad = null,
                motivoRechazo = null,
                fechaRegistro = "03-03-2022",
                puesto = "ayudante",
                capacitadoChofer = '1',
                estatus = "activo",
                motivo = null,
                descripcion = null,
                fechaMotivo = null,
                fotografia = null,
                placas = "hgg66",
                tipoUnidad = "pickup"
            };
            var IdCreado = manager.Guardar(objetoGuardar);


            return View();
        }

        // POST: Administracion/Operador/Create
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

        // GET: Administracion/Operador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Administracion/Operador/Edit/5
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

        // GET: Administracion/Operador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administracion/Operador/Delete/5
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
