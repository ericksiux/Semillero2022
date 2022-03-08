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
            return View();
        }
        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult Editar()
        {
            return View();
        }
    }
}