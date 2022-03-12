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
            var temp = model.TodosFleteros = managerF.ObtenerFleteroInfoGeneral();

            List<FleteroDTO> lst = new List<FleteroDTO>();

            for (int i = 0; i < model.TodosFleteros.Count; i++)
            {
                lst.Add(managerF.ObtenerFleteroInfoDetallada(temp[i].idFletero));

            }
            model.FleterosDetalle = lst;
            return View(model);
        }
        public ActionResult Agregar()
        {
            FleteroModel model = new FleteroModel();
            IDistritoManager manager = new DistritoManager();
            model.Districts = manager.ObtenerDistritos();

            ITiendaManager managerT = new TiendaManager();
            model.Stores = managerT.ObtenerTiendas(0);

            IEstadoManager managerE = new EstadoManager();
            model.EstadoF = managerE.ObtenerEstado();

            IMunicipioManager managerMF = new MunicipioManager();
            model.MunicipiosF = managerMF.ObtenerMunicipio(0);

            model.EstadoB = managerE.ObtenerEstado();
            model.MunicipiosB = managerMF.ObtenerMunicipio(0);

            return View(model);
        }
        public ActionResult Editar()
        {
            return View();
        }
        public ActionResult Buscar()
        {
            FleteroModel model = new FleteroModel();
            IDistritoManager manager = new DistritoManager();
            model.Districts = manager.ObtenerDistritos();

            ITiendaManager managerT = new TiendaManager();
            model.Stores = managerT.ObtenerTiendas(0);

            IFleteroManager managerF = new FleteroManager();
            var temp = model.TodosFleteros = managerF.ObtenerFleteroInfoGeneral();

            List<FleteroDTO> lst = new List<FleteroDTO>();

            for (int i = 0; i < model.TodosFleteros.Count; i++)
            {
                lst.Add(managerF.ObtenerFleteroInfoDetallada(temp[i].idFletero));

            }
            model.FleterosDetalle = lst;

            return View(model);
        }
        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Buscar(FleteroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    IFleteroManager manager = new FleteroManager();
                    var idLastF = manager.ObtenerFleteroFiltros(model.distrito, model.tienda, model.idFletero, model.estado);


                    return Json(new { Success = 1, ValueA = idLastF}, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { Success = 0, Data = ex }, JsonRequestBehavior.AllowGet);

                }

            }
            else
            {
                return Json(new { Success = 0 }, JsonRequestBehavior.AllowGet);

            }
        }

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Agregar(FleteroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    FleteroDTO fleteroDTO = new FleteroDTO();

                    fleteroDTO.nombreFletero = model.nombreFletero;
                    fleteroDTO.RFC = model.RFC;
                    fleteroDTO.dirFCalle = model.dirFCalle;
                    fleteroDTO.dirFNum = model.dirFNum;
                    fleteroDTO.dirFCol = model.dirFCol;
                    fleteroDTO.dirFMunicipio = model.dirFMunicipio;
                    fleteroDTO.dirFCP = model.dirFCP;
                    fleteroDTO.dirBCalle = model.dirBCalle;
                    fleteroDTO.dirBNum = model.dirBNum;
                    fleteroDTO.dirBCol = model.dirBCol;
                    fleteroDTO.dirBMunicipio = model.dirBMunicipio;
                    fleteroDTO.dirBCP = model.dirBCP;
                    fleteroDTO.nombreRepresentante = model.nombreRepresentante;
                    fleteroDTO.nombreCont = model.nombreCont;
                    fleteroDTO.telCelCont = model.telCelCont;
                    fleteroDTO.telOficinaCont = model.telOficinaCont;
                    fleteroDTO.telNextelCont = model.telNextelCont;
                    fleteroDTO.correoPrincipal = model.correoPrincipal;
                    fleteroDTO.fechaAlta = model.fechaAlta;
                    fleteroDTO.indicadorCertif = 0;
                    fleteroDTO.estado = 1;

                    IFleteroManager manager = new FleteroManager();
                    var idLastF = manager.RegistrarFletero(fleteroDTO);
                    var idLastDistTienda = manager.AgregarTiendasFletero(0, model.idTiendaDistTienda);

                    return Json(new { Success = 1, ValueA = idLastF, ValueB = idLastDistTienda }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { Success = 0, Data = ex }, JsonRequestBehavior.AllowGet);

                }

            }
            else
            {
                return Json(new { Success = 0}, JsonRequestBehavior.AllowGet);

            }
        }

        [HttpGet]
        public ActionResult GetTiendasList(int id)
        {

            ITiendaManager manager = new TiendaManager();
            var tiendas = manager.ObtenerTiendas(id);
            return Json(tiendas, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult GetMunicipiosList(int id)
        {

            IMunicipioManager manager = new MunicipioManager();
            var municipios = manager.ObtenerMunicipio(id);
            return Json(municipios, JsonRequestBehavior.AllowGet);
        }


    }
}