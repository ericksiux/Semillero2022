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
    public class ContratoDAO
    {
        public List<ContratoDTO> ObtenerContrato(ContratoMapper ContratoMapper)
        {
            List<ContratoDTO> ContratoList = new List<ContratoDTO>();

            try
            {
                var ds = DALHelper.Retrive("Contratos_Obtener");
                ContratoList = ContratoMapper.ContratoDStoList(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ContratoList;
        }

        public List<ContratoDTO> ObtenerContrato()
        {
            throw new NotImplementedException();
        }

        public int Guardar(ContratoDTO ContratoDTO, int idContrato)
        {
            int idContrato = 0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@pIdContrato", Value = idContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pLugarFirmaContrato", Value = ContratoDTO.lugarFirmaContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pFechaFirmaContrato", Value = ContratoDTO.fechaFirmaContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pQuienFirmaHomeDepot", Value = ContratoDTO.quienFirmaHomeDepot });
                parameters.Add(new SqlParameter { ParameterName = "@pQuienFirmaFletero", Value = ContratoDTO.quienFirmaFletero });
                parameters.Add(new SqlParameter { ParameterName = "@pQuienRealizoFirma", Value = ContratoDTO.quienRealizoFirma });
                parameters.Add(new SqlParameter { ParameterName = "@pFechaInicioContrato", Value = ContratoDTO.fechaInicioContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pFechaTerminacionContrato", Value = ContratoDTO.fechaTerminacionContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pRenovacionAutomatica", Value = ContratoDTO.renovacionAutomatica });
                parameters.Add(new SqlParameter { ParameterName = "@pRegion", Value = ContratoDTO.IDREGION });
                parameters.Add(new SqlParameter { ParameterName = "@pDistrito", Value = ContratoDTO.IDDISTRICT });
                parameters.Add(new SqlParameter { ParameterName = "@pTienda", Value = ContratoDTO.IDSTORE });
                parameters.Add(new SqlParameter { ParameterName = "@pFletero", Value = ContratoDTO.idFletero });
                parameters.Add(new SqlParameter { ParameterName = "@pStatusContrato", Value = ContratoDTO.statusContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pTarifa", Value = ContratoDTO.idCampoTarifa });
                parameters.Add(new SqlParameter { ParameterName = "@pArchivo", Value = ContratoDTO.idArchivo });
                
                var ds = DALHelper.Retrive("Contratos_Insertar", parameters);

                idContrato = ContratoMapper.ContratoDStoContratoID(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return idContrato;
        }

        public ContratoDTO Editar(ContratoDTO contratoDTO)
        {
            throw new NotImplementedException();
        }

        public int Guardar(ContratoDTO contratoDTO)
        {
            throw new NotImplementedException();
        }

        public ContratoDTO Editar(ContratoDTO ContratoDTO, int idContrato)
        {
            ContratoDTO idContrato = new ContratoDTO();
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@pIdContrato", Value = idContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pLugarFirmaContrato", Value = ContratoDTO.lugarFirmaContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pFechaFirmaContrato", Value = ContratoDTO.fechaFirmaContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pQuienFirmaHomeDepot", Value = ContratoDTO.quienFirmaHomeDepot });
                parameters.Add(new SqlParameter { ParameterName = "@pQuienFirmaFletero", Value = ContratoDTO.quienFirmaFletero });
                parameters.Add(new SqlParameter { ParameterName = "@pQuienRealizoFirma", Value = ContratoDTO.quienRealizoFirma });
                parameters.Add(new SqlParameter { ParameterName = "@pFechaInicioContrato", Value = ContratoDTO.fechaInicioContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pFechaTerminacionContrato", Value = ContratoDTO.fechaTerminacionContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pRenovacionAutomatica", Value = ContratoDTO.renovacionAutomatica });
                parameters.Add(new SqlParameter { ParameterName = "@pRegion", Value = ContratoDTO.IDREGION });
                parameters.Add(new SqlParameter { ParameterName = "@pDistrito", Value = ContratoDTO.IDDISTRICT });
                parameters.Add(new SqlParameter { ParameterName = "@pTienda", Value = ContratoDTO.IDSTORE });
                parameters.Add(new SqlParameter { ParameterName = "@pFletero", Value = ContratoDTO.idFletero });
                parameters.Add(new SqlParameter { ParameterName = "@pStatusContrato", Value = ContratoDTO.statusContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pTarifa", Value = ContratoDTO.idCampoTarifa });
                parameters.Add(new SqlParameter { ParameterName = "@pArchivo", Value = ContratoDTO.idArchivo });

                var ds = DALHelper.Retrive("Contratos_Editar", parameters);

                idContrato = ContratoMapper.ContratostoDTO(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return idContrato;
        }


        public int HabilitarContrato(int idContrato, MotivoDTO motivodto)
        {
            int idContrato = 0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@opc", Value = 1 }); //Habilitar
                parameters.Add(new SqlParameter { ParameterName = "@idContrato", Value = idContrato });
                parameters.Add(new SqlParameter { ParameterName = "@motivo", Value = motivodto.motivo }); 
                parameters.Add(new SqlParameter { ParameterName = "@fechaMotivo", Value = motivodto.fecha });  
                parameters.Add(new SqlParameter { ParameterName = "@descripcion", Value = motivodto.descripcion }); 

                var ds = DALHelper.Retrive("Contratos_CambiarEstatus", parameters);
                idContrato = ContratoMapper.FleteroDStoDemoID_HabilitarFletero(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return idContrato;
        }
        public int DeshabilitarContrato(int idContrato, MotivoDTO motivodto)//Bien
        {
            int idContrato = 0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@opc", Value = 1 }); //Habilitar
                parameters.Add(new SqlParameter { ParameterName = "@idContrato", Value = idContrato });
                parameters.Add(new SqlParameter { ParameterName = "@motivo", Value = motivodto.motivo });
                parameters.Add(new SqlParameter { ParameterName = "@fechaMotivo", Value = motivodto.fecha });
                parameters.Add(new SqlParameter { ParameterName = "@descripcion", Value = motivodto.descripcion });

                var ds = DALHelper.Retrive("Contratos_CambiarEstatus", parameters);
                idContrato = FleteroMapper.FleteroDStoDemoID_DeshabilitarFletero(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return idContrato;
        }
    }
}
