using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public static class FleteroMapper
    {
        public static int FleteroDStoDemoID_RegistrarModificarFletero(DataSet ds)
        {
            if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["ultimoFletero"]);
            }

            return 0;
        }
        public static int FleteroDStoDemoID_AgregarTiendasFletero(DataSet ds)
        {
            if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["ultimoIdDistTienda"]);
            }

            return 0;
        }
        public static int FleteroDStoDemoID_HabilitarFletero(DataSet ds)
        {
            if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["idmot"]);
            }

            return 0;
        }
        public static int FleteroDStoDemoID_DeshabilitarFletero(DataSet ds)
        {
            if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["idmotd"]);
            }

            return 0;
        }
        public static List<FleteroDTO> FleteroDSToList_ObtenerFleteroFiltros(DataSet ds)
        {
            List<FleteroDTO> flet = new List<FleteroDTO>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var fletero = new FleteroDTO();

                fletero.DistrictName = Convert.ToString(row["DISTRICTNAME"]);
                fletero.StoreName = Convert.ToString(row["STORENAME"]);
                fletero.nombreFletero = Convert.ToString(row["nombreFletero"]);
                fletero.nombreCont = Convert.ToString(row["nombreCont"]);
                fletero.telCelCont = Convert.ToString(row["telCelCont"]);
                fletero.telOficinaCont = Convert.ToString(row["telOficinaCont"]);
                fletero.telNextelCont = Convert.ToString(row["telNextelCont"]);
                fletero.correoPrincipal = Convert.ToString(row["correoPrincipal"]);
                fletero.tipoEstado = Convert.ToString(row["EstadoDescripcion"]);
                fletero.tituloMotivo = Convert.ToString(row["MotivoTitulo"]);
               
                flet.Add(fletero);
            }

            return flet;
        }
        public static List<FleteroDTO> FleteroDSToList_ObtenerFletero(DataSet ds)
        {
            List<FleteroDTO> flet = new List<FleteroDTO>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var fletero = new FleteroDTO();

                fletero.DistrictName = Convert.ToString(row["DISTRICTNAME"]);
                fletero.StoreName = Convert.ToString(row["STORENAME"]);
                fletero.nombreFletero = Convert.ToString(row["nombreFletero"]);
                fletero.dirFCalle = Convert.ToString(row["dirFCalle"]);
                fletero.dirFNum = Convert.ToInt32(row["dirFNum"]);
                fletero.dirFCol = Convert.ToString(row["dirFCol"]);
                fletero.dirFMunicipio_Estado = Convert.ToString(row["EstadoF"]);
                fletero.dirFMunicipio_Municipio = Convert.ToString(row["MunicipioF"]);
                fletero.dirFCP = Convert.ToInt32(row["dirFCP"]);
                fletero.dirBCalle = Convert.ToString(row["dirBCalle"]);
                fletero.dirBNum = Convert.ToInt32(row["dirBNum"]);
                fletero.dirBCol = Convert.ToString(row["dirBCol"]);
                fletero.dirBMunicipio_Estado = Convert.ToString(row["EstadoB"]);
                fletero.dirBMunicipio_Municipio = Convert.ToString(row["MunicipioB"]);
                fletero.dirBCP = Convert.ToInt32(row["dirBCP"]);
                fletero.nombreRepresentante = Convert.ToString(row["nombreRepresentante"]);
                fletero.nombreCont = Convert.ToString(row["nombreCont"]);
                fletero.telCelCont = Convert.ToString(row["telCelCont"]);
                fletero.telOficinaCont = Convert.ToString(row["telOficinaCont"]);
                fletero.telNextelCont = Convert.ToString(row["telNextelCont"]);
                fletero.correoPrincipal = Convert.ToString(row["correoPrincipal"]);
                fletero.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                fletero.indicadorCertif = Convert.ToInt32(row["indicadorCertif"]);

                flet.Add(fletero);
            }

            return flet;
        }
        public static List<FleteroDTO> FleteroDSToList_ObtenerFleteroInfoGeneral(DataSet ds)
        {
            List<FleteroDTO> flet = new List<FleteroDTO>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var fletero = new FleteroDTO();
                
                fletero.idFletero = Convert.ToInt32(row["idFletero"]);
                fletero.DistrictName = Convert.ToString(row["DISTRICTNAME"]);
                fletero.StoreName = Convert.ToString(row["STORENAME"]);
                fletero.nombreFletero = Convert.ToString(row["nombreFletero"]);
                fletero.nombreCont = Convert.ToString(row["nombreCont"]);
                fletero.telCelCont = Convert.ToString(row["telCelCont"]);
                fletero.telOficinaCont = Convert.ToString(row["telOficinaCont"]);
                fletero.telNextelCont = Convert.ToString(row["telNextelCont"]);
                fletero.correoPrincipal = Convert.ToString(row["correoPrincipal"]);
                fletero.tipoEstado = Convert.ToString(row["TipoEstado"]);
                fletero.tituloMotivo= Convert.ToString(row["TituloMotivo"]);

                flet.Add(fletero);
            }

            return flet;
        }
        public static FleteroDTO FleteroDSToList_ObtenerFleteroInfoDetallada(DataSet ds)
        {
            FleteroDTO flet = new FleteroDTO();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var fletero = new FleteroDTO();

                fletero.idFletero = Convert.ToInt32(row["idFletero"]);
                fletero.DistrictName = Convert.ToString(row["DISTRICTNAME"]);
                fletero.StoreName = Convert.ToString(row["STORENAME"]);
                fletero.nombreFletero = Convert.ToString(row["nombreFletero"]);
                fletero.RFC = Convert.ToString(row["RFC"]);
                fletero.dirFCalle = Convert.ToString(row["dirFCalle"]);
                fletero.dirFNum = Convert.ToInt32(row["dirFNum"]);
                fletero.dirFCol = Convert.ToString(row["dirFCol"]);
                fletero.dirFMunicipio_Estado = Convert.ToString(row["EstadoF"]);
                fletero.dirFMunicipio_Municipio = Convert.ToString(row["MunicipioF"]);
                fletero.dirFCP = Convert.ToInt32(row["dirFCP"]);
                fletero.nombreRepresentante = Convert.ToString(row["nombreRepresentante"]);
                fletero.nombreCont = Convert.ToString(row["nombreCont"]);
                fletero.telCelCont = Convert.ToString(row["telCelCont"]);
                fletero.telOficinaCont = Convert.ToString(row["telOficinaCont"]);
                fletero.telNextelCont = Convert.ToString(row["telNextelCont"]);
                fletero.correoPrincipal = Convert.ToString(row["correoPrincipal"]);
                fletero.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                
                flet = fletero;
            }

            return flet;
        }
    }
}
