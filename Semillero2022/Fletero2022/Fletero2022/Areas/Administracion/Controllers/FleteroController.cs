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

            ITituloMotivoManager managerTM = new TituloMotivoManager();
            model.TituloMotivo = managerTM.ObtenerTituloMotivos();
            
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

        public JsonResult AgregarMotivoDeshabilitar()
        {
            try
            {
                var id = Convert.ToInt32(Request.Params["idFletero"]);

                MotivoDTO mdto = new MotivoDTO();
                mdto.motivo = Convert.ToInt32(Request.Params["idMotivo"]);
                mdto.descripcion = Convert.ToString(Request.Params["desc"]);
                mdto.fecha = DateTime.Now;

                IFleteroManager managerF = new FleteroManager();
                int idFletero= managerF.DeshabilitarFletero(id, mdto);

                return Json(new { Success = 1, ValueA = idFletero }, JsonRequestBehavior.AllowGet);

            }catch (Exception ex)
            {
                return Json(new { Success = 0, Data = ex }, JsonRequestBehavior.AllowGet);
            }

        }
        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]

        public JsonResult AgregarMotivoHabilitar()
        {
            try
            {
                var id = Convert.ToInt32(Request.Params["idFletero"]);

                MotivoDTO mdto = new MotivoDTO();
                mdto.motivo = Convert.ToInt32(Request.Params["idMotivo"]);
                mdto.descripcion = Convert.ToString(Request.Params["desc"]);
                mdto.fecha = DateTime.Now;

                IFleteroManager managerF = new FleteroManager();
                int idFletero = managerF.HabilitarFletero(id, mdto);

                return Json(new { Success = 1, ValueA = idFletero }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { Success = 0, Data = ex }, JsonRequestBehavior.AllowGet);
            }

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
        [HttpPost]
        public ActionResult Editar(FleteroModel model)
        {
            FleteroDTO fleteroDTO = new FleteroDTO();

            fleteroDTO.idFletero = model.idFletero;
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

            IFleteroManager manager = new FleteroManager();
            var idLastF = manager.ModificarFletero(fleteroDTO);

            return Json(new { Success = 1, ValueA = idLastF }, JsonRequestBehavior.AllowGet);

        }
        public ActionResult Editar(int id)
        {
            FleteroModel model = new FleteroModel();
            IFleteroManager managerF = new FleteroManager();

            model.FleteroModificar = managerF.ObtenerFletero(id);

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

        [HttpGet]
        public ActionResult Buscar()
        {
            FleteroModel model = new FleteroModel();
            /*IDistritoManager manager = new DistritoManager();
            model.Districts = manager.ObtenerDistritos();

            ITiendaManager managerT = new TiendaManager();
            model.Stores = managerT.ObtenerTiendas(0);
            */

            int distrito, tienda, idFletero, estado;
            
            if(Request.Params["distrito"] != "")
            {
                distrito = Convert.ToInt32(Request.Params["distrito"]);
            }
            else
            {
               distrito = 0;
            }

            if(Request.Params["tienda"] != "")
            {
               tienda = Convert.ToInt32(Request.Params["tienda"]);
            }
            else
            {
                tienda = 0;
            }

            if (Request.Params["id"] != "")
            {
                idFletero = Convert.ToInt32(Request.Params["id"]);
            }
            else
            {
                idFletero = 0;
            }

            if(Request.Params["estado"] != "")
            {
                estado = Convert.ToInt32(Request.Params["estado"]);
            }
            else
            {
                estado = 0;
            }

            IFleteroManager managerF = new FleteroManager();
            var fleterosFiltrosBusqueda = managerF.ObtenerFleteroFiltros(distrito, tienda, idFletero, estado);

            model.TodosFleteros = managerF.ObtenerFleteroInfoGeneral();

            model.FleteroBusquedaFiltros = fleterosFiltrosBusqueda;

            List<FleteroDTO> lst = new List<FleteroDTO>();

            for (int i = 0; i < fleterosFiltrosBusqueda.Count; i++)
            {
                lst.Add(managerF.ObtenerFleteroInfoDetallada(fleterosFiltrosBusqueda[i].idFletero));

            }
            model.FleterosDetalle = lst;

            return PartialView("_FleterosGrid", model);
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