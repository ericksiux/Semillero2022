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
        public IEnumerable<ContratoDTO> ObtenerContrato(int contrato)
        {
            IEnumerable<ContratoDTO> ContratoList = null;

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

        public int Guardar(ContratoDTO ContratoDTO)
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
            var dto = new ContratoDTO();
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@pIdContrato", Value = contratoDTO.idContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pLugarFirmaContrato", Value = contratoDTO.lugarFirmaContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pFechaFirmaContrato", Value = contratoDTO.fechaFirmaContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pQuienFirmaHomeDepot", Value = contratoDTO.quienFirmaHomeDepot });
                parameters.Add(new SqlParameter { ParameterName = "@pQuienFirmaFletero", Value = contratoDTO.quienFirmaFletero });
                parameters.Add(new SqlParameter { ParameterName = "@pQuienRealizoFirma", Value = contratoDTO.quienRealizoFirma });
                parameters.Add(new SqlParameter { ParameterName = "@pFechaInicioContrato", Value = contratoDTO.fechaInicioContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pFechaTerminacionContrato", Value = contratoDTO.fechaTerminacionContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pRenovacionAutomatica", Value = contratoDTO.renovacionAutomatica });
                parameters.Add(new SqlParameter { ParameterName = "@pRegion", Value = contratoDTO.IDREGION });
                parameters.Add(new SqlParameter { ParameterName = "@pDistrito", Value = contratoDTO.IDDISTRICT });
                parameters.Add(new SqlParameter { ParameterName = "@pTienda", Value = contratoDTO.IDSTORE });
                parameters.Add(new SqlParameter { ParameterName = "@pFletero", Value = contratoDTO.idFletero });
                parameters.Add(new SqlParameter { ParameterName = "@pStatusContrato", Value = contratoDTO.statusContrato });
                parameters.Add(new SqlParameter { ParameterName = "@pTarifa", Value = contratoDTO.idCampoTarifa });
                parameters.Add(new SqlParameter { ParameterName = "@pArchivo", Value = contratoDTO.idArchivo });

                var ds = DALHelper.Retrive("Contratos_Editar", parameters);

                dto = ContratoMapper.ContratostoDTO(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dto;
        }


        public int HabilitarContrato(int idContrato, MotivoDTO motivodto)
        {
            int idhabilitarContrato = 0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@opc", Value = 1 }); //Habilitar
                parameters.Add(new SqlParameter { ParameterName = "@idContrato", Value = idContrato });
                parameters.Add(new SqlParameter { ParameterName = "@motivo", Value = motivodto.motivo });
                parameters.Add(new SqlParameter { ParameterName = "@fechaMotivo", Value = motivodto.fecha });
                parameters.Add(new SqlParameter { ParameterName = "@descripcion", Value = motivodto.descripcion });

                var ds = DALHelper.Retrive("Contratos_CambiarEstatus", parameters);
                idhabilitarContrato = ContratoMapper.ContratoDStoidContrato_HabilitarContrato(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return idContrato;
        }
        public int DeshabilitarContrato(int idContrato, MotivoDTO motivodto)//Bien
        {
            int iddeshabilitarContrato = 0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@opc", Value = 1 }); //Habilitar
                parameters.Add(new SqlParameter { ParameterName = "@idContrato", Value = idContrato });
                parameters.Add(new SqlParameter { ParameterName = "@motivo", Value = motivodto.motivo });
                parameters.Add(new SqlParameter { ParameterName = "@fechaMotivo", Value = motivodto.fecha });
                parameters.Add(new SqlParameter { ParameterName = "@descripcion", Value = motivodto.descripcion });

                var ds = DALHelper.Retrive("Contratos_CambiarEstatus", parameters);
                iddeshabilitarContrato = ContratoMapper.ContratoDStoidContrato_DeshabilitarContrato(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return idContrato;
        }
    }
}
