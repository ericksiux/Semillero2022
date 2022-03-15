using Fletero.Administracion.Integration.DAO.Helper;
using Fletero.Administracion.Integration.DAO.Mapper;
using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO
{
    public class FleteroDAO
    {
        public int RegistrarFletero(FleteroDTO fleterodto) //Bien
        {
            int ID = 0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@opc", Value = 1 });
                parameters.Add(new SqlParameter { ParameterName = "@idFletero", Value = DBNull.Value});
                parameters.Add(new SqlParameter { ParameterName = "@nombreFletero", Value = fleterodto.nombreFletero });
                parameters.Add(new SqlParameter { ParameterName = "@RFC", Value = fleterodto.RFC });
                parameters.Add(new SqlParameter { ParameterName = "@dirFCalle", Value = fleterodto.dirFCalle });
                parameters.Add(new SqlParameter { ParameterName = "@dirFNum", Value = fleterodto.dirFNum });
                parameters.Add(new SqlParameter { ParameterName = "@dirFCol", Value = fleterodto.dirFCol });
                parameters.Add(new SqlParameter { ParameterName = "@dirFMunicipio", Value = fleterodto.dirFMunicipio });
                parameters.Add(new SqlParameter { ParameterName = "@dirFCP", Value = fleterodto.dirFCP });
                parameters.Add(new SqlParameter { ParameterName = "@dirBCalle", Value = fleterodto.dirBCalle });
                parameters.Add(new SqlParameter { ParameterName = "@dirBNum", Value = fleterodto.dirBNum });
                parameters.Add(new SqlParameter { ParameterName = "@dirBCol", Value = fleterodto.dirBCol });
                parameters.Add(new SqlParameter { ParameterName = "@dirBMunicipio", Value = fleterodto.dirBMunicipio });
                parameters.Add(new SqlParameter { ParameterName = "@dirBCP", Value = fleterodto.dirBCP });
                parameters.Add(new SqlParameter { ParameterName = "@nombreRepresentante", Value = fleterodto.nombreRepresentante });
                parameters.Add(new SqlParameter { ParameterName = "@nombreCont", Value = fleterodto.nombreCont });
                parameters.Add(new SqlParameter { ParameterName = "@telCelCont", Value = fleterodto.telCelCont });
                parameters.Add(new SqlParameter { ParameterName = "@telOficinaCont", Value = fleterodto.telOficinaCont });
                parameters.Add(new SqlParameter { ParameterName = "@telNextelCont", Value = fleterodto.telNextelCont });
                parameters.Add(new SqlParameter { ParameterName = "@correoPrincipal", Value = fleterodto.correoPrincipal });
                parameters.Add(new SqlParameter { ParameterName = "@fechaAlta", Value = fleterodto.fechaAlta });
                parameters.Add(new SqlParameter { ParameterName = "@indicadorCertif", Value = fleterodto.indicadorCertif });
                parameters.Add(new SqlParameter { ParameterName = "@estado", Value = fleterodto.estado });
                parameters.Add(new SqlParameter { ParameterName = "@motivo", Value = DBNull.Value });

                var ds = DALHelper.Retrive("sp_Fleteros", parameters);
                ID = FleteroMapper.FleteroDStoDemoID_RegistrarModificarFletero(ds);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ID;
        }
        public int ModificarFletero(FleteroDTO fleterodto)//Bien
        {
            int ID = 0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@opc", Value = 2 });
                parameters.Add(new SqlParameter { ParameterName = "@idFletero", Value = fleterodto.idFletero });
                parameters.Add(new SqlParameter { ParameterName = "@nombreFletero", Value = DBNull.Value });
                parameters.Add(new SqlParameter { ParameterName = "@RFC", Value = DBNull.Value });
                parameters.Add(new SqlParameter { ParameterName = "@dirFCalle", Value = fleterodto.dirFCalle });
                parameters.Add(new SqlParameter { ParameterName = "@dirFNum", Value = fleterodto.dirFNum });
                parameters.Add(new SqlParameter { ParameterName = "@dirFCol", Value = fleterodto.dirFCol });
                parameters.Add(new SqlParameter { ParameterName = "@dirFMunicipio", Value = fleterodto.dirFMunicipio });
                parameters.Add(new SqlParameter { ParameterName = "@dirFCP", Value = fleterodto.dirFCP });
                parameters.Add(new SqlParameter { ParameterName = "@dirBCalle", Value = fleterodto.dirBCalle });
                parameters.Add(new SqlParameter { ParameterName = "@dirBNum", Value = fleterodto.dirBNum });
                parameters.Add(new SqlParameter { ParameterName = "@dirBCol", Value = fleterodto.dirBCol });
                parameters.Add(new SqlParameter { ParameterName = "@dirBMunicipio", Value = fleterodto.dirBMunicipio });
                parameters.Add(new SqlParameter { ParameterName = "@dirBCP", Value = fleterodto.dirBCP });
                parameters.Add(new SqlParameter { ParameterName = "@nombreRepresentante", Value = fleterodto.nombreRepresentante });
                parameters.Add(new SqlParameter { ParameterName = "@nombreCont", Value = fleterodto.nombreCont });
                parameters.Add(new SqlParameter { ParameterName = "@telCelCont", Value = fleterodto.telCelCont });
                parameters.Add(new SqlParameter { ParameterName = "@telOficinaCont", Value = fleterodto.telOficinaCont });
                parameters.Add(new SqlParameter { ParameterName = "@telNextelCont", Value = fleterodto.telNextelCont });
                parameters.Add(new SqlParameter { ParameterName = "@correoPrincipal", Value = fleterodto.correoPrincipal });
                parameters.Add(new SqlParameter { ParameterName = "@fechaAlta", Value = DBNull.Value });
                parameters.Add(new SqlParameter { ParameterName = "@indicadorCertif", Value = DBNull.Value });
                parameters.Add(new SqlParameter { ParameterName = "@estado", Value = DBNull.Value });
                parameters.Add(new SqlParameter { ParameterName = "@motivo", Value = DBNull.Value });
            
                var ds = DALHelper.Retrive("sp_Fleteros", parameters);
                ID = FleteroMapper.FleteroDStoDemoID_RegistrarModificarFletero(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ID;
        }
        public int HabilitarFletero(int idFletero, MotivoDTO motivodto) //Bien
        {
            int ID = 0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@opc", Value = 1 }); //Habilitar
                parameters.Add(new SqlParameter { ParameterName = "@idFletero", Value = idFletero }); 
                parameters.Add(new SqlParameter { ParameterName = "@motivo", Value = motivodto.motivo}); //Motivo ID titulo
                parameters.Add(new SqlParameter { ParameterName = "@fechaMotivo", Value = motivodto.fecha}); //fechaMotivo 
                parameters.Add(new SqlParameter { ParameterName = "@descripcion", Value = motivodto.descripcion }); //Descripcion
                
                var ds= DALHelper.Retrive("sp_Fleteros_CambiarEstado", parameters);
                ID = FleteroMapper.FleteroDStoDemoID_HabilitarFletero(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ID;
        }
        public int DeshabilitarFletero(int idFletero, MotivoDTO motivodto)//Bien
        {
            int ID =0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@opc", Value = 2 }); //Deshabilitar
                parameters.Add(new SqlParameter { ParameterName = "@idFletero", Value = idFletero });
                parameters.Add(new SqlParameter { ParameterName = "@motivo", Value = motivodto.motivo }); //Motivo ID titulo
                parameters.Add(new SqlParameter { ParameterName = "@fechaMotivo", Value = motivodto.fecha }); //fechaMotivo 
                parameters.Add(new SqlParameter { ParameterName = "@descripcion", Value = motivodto.descripcion }); //Descripcion

                var ds = DALHelper.Retrive("sp_Fleteros_CambiarEstado", parameters);
                ID = FleteroMapper.FleteroDStoDemoID_DeshabilitarFletero(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ID;
        }
        public int AgregarTiendasFletero(int idFletero, int idTienda)
        {
            int ID = 0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@opc", Value = 1 }); 
                parameters.Add(new SqlParameter { ParameterName = "@idFletero", Value = DBNull.Value });
                parameters.Add(new SqlParameter { ParameterName = "@idTienda", Value = idTienda }); 

                var ds = DALHelper.Retrive("sp_Fletero_DisTienda", parameters);
                ID = FleteroMapper.FleteroDStoDemoID_AgregarTiendasFletero(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ID;
        }
        public List<FleteroDTO> ObtenerFletero(int idFletero) //Bien
        {
            List <FleteroDTO> fList = new List <FleteroDTO>();
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@opc", Value = 3 });
                parameters.Add(new SqlParameter { ParameterName = "@id", Value = idFletero });

                var ds = DALHelper.Retrive("sp_Fletero_Consultas", parameters);
                fList = FleteroMapper.FleteroDSToList_ObtenerFletero(ds);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return fList;
        }
        public List<FleteroDTO> ObtenerFleteroInfoGeneral() //Bien
        {
            List<FleteroDTO> fList = new List<FleteroDTO>();
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@opc", Value = 1 });
                parameters.Add(new SqlParameter { ParameterName = "@id", Value = DBNull.Value});

                var ds = DALHelper.Retrive("sp_Fletero_Consultas", parameters);
                fList = FleteroMapper.FleteroDSToList_ObtenerFleteroInfoGeneral(ds);               

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return fList;
        }
        public FleteroDTO ObtenerFleteroInfoDetallada(int idFletero) //Bien
        {
            FleteroDTO fList = new FleteroDTO();
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@opc", Value = 2 });
                parameters.Add(new SqlParameter { ParameterName = "@id", Value = idFletero });

                var ds = DALHelper.Retrive("sp_Fletero_Consultas", parameters);
                fList = FleteroMapper.FleteroDSToList_ObtenerFleteroInfoDetallada(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return fList;
        }
        public List<FleteroDTO> ObtenerFleteroFiltros(int? idDistrito, int? idTienda, int? idFletero, int? idEstado) //Corregir valores nulos, creo que ya quedó
        {
            
            List<FleteroDTO> fList = new List<FleteroDTO>();
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@idDistrito", Value = idDistrito });
                parameters.Add(new SqlParameter { ParameterName = "@idTienda", Value = idTienda });
                parameters.Add(new SqlParameter { ParameterName = "@fletero", Value = idFletero });
                parameters.Add(new SqlParameter { ParameterName = "@estado", Value = idEstado });

                var ds = DALHelper.Retrive("sp_Fletero_ConsultasFiltro", parameters);
                fList = FleteroMapper.FleteroDSToList_ObtenerFleteroFiltros(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return fList;
        }


    }
}
