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
    public class FleteroController : Controller
    {
        // GET: Administracion/Fletero
        public ActionResult Index()
        {
            FleteroModel model = new FleteroModel();
            IDistritoManager manager = new DistritoManager();
            model.Districts = manager.ObtenerDistritos();

            ITiendaManager managerT = new TiendaManager();
            model.Stores = managerT.ObtenerTiendas(0);

            IFleteroManager managerF = new FleteroManager();
            model.TodosFleteros = managerF.ObtenerFleteroInfoGeneral();

            return View(model);
        }
        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult Editar()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetTiendasList(int id)
        {

            ITiendaManager manager = new TiendaManager();
            var tiendas = manager.ObtenerTiendas(id);
            return Json(tiendas, JsonRequestBehavior.AllowGet);
        }
        

    }
}