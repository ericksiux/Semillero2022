using System;
using Fletero.Administracion.Integration.DAO.Helper;
using Fletero.Administracion.Integration.DAO.Mapper;
using Fletero.Administracion.Services.Contracs.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fletero.Administracion.Integration.DAO
{
    public class operadorDAO
    {
        public List<OperadorDTO> ObtenerOperadorList()
        {
            List<OperadorDTO> operadorList = new List<OperadorDTO>();

            try
            {
                var ds = DALHelper.Retrive("Operador_buscar");
                operadorList = OperadorMapper.OperadorDStoList(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return operadorList;
        }

        public int Guardar(OperadorDTO operadorDTO)
        {
            int idOperador = 0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@distrito", Value = operadorDTO.distrito });
                parameters.Add(new SqlParameter { ParameterName = "@fletero", Value = operadorDTO .fletero});
                parameters.Add(new SqlParameter { ParameterName = "@unidad", Value = operadorDTO .unidad});
                parameters.Add(new SqlParameter { ParameterName = "@nombre", Value = operadorDTO.nombre });
                parameters.Add(new SqlParameter { ParameterName = "@apellidoPat", Value = operadorDTO.apellidoPat });
                parameters.Add(new SqlParameter { ParameterName = "@apellidoMat", Value = operadorDTO.apellidoMAt });
                parameters.Add(new SqlParameter { ParameterName = "@calle", Value = operadorDTO.calle });
                parameters.Add(new SqlParameter { ParameterName = "@numero", Value = operadorDTO.numero });
                parameters.Add(new SqlParameter { ParameterName = "@colonia", Value = operadorDTO.colonia });
                parameters.Add(new SqlParameter { ParameterName = "@municipio", Value = operadorDTO.municipio });
                parameters.Add(new SqlParameter { ParameterName = "@estado", Value = operadorDTO.estado });
                parameters.Add(new SqlParameter { ParameterName = "@cp", Value = operadorDTO.cp });
                parameters.Add(new SqlParameter { ParameterName = "@noCredencialElector", Value = operadorDTO.noCredencialElector });
                parameters.Add(new SqlParameter { ParameterName = "@fechaVigenciaLicencia", Value = operadorDTO.fechaVigenciaLicencia });
                parameters.Add(new SqlParameter { ParameterName = "@noLicencia", Value = operadorDTO.noLicencia });
                parameters.Add(new SqlParameter { ParameterName = "@padecimientos", Value = operadorDTO.padecimientos });
                parameters.Add(new SqlParameter { ParameterName = "@curp", Value = operadorDTO.curp });
                parameters.Add(new SqlParameter { ParameterName = "@noIMSS", Value = operadorDTO.noIMSS });
                parameters.Add(new SqlParameter { ParameterName = "@estatusConfidencialidad", Value = operadorDTO.estatusConfiabilidad });
                parameters.Add(new SqlParameter { ParameterName = "@motivoRechazo", Value = operadorDTO.motivoRechazo });
                parameters.Add(new SqlParameter { ParameterName = "@fechaRegistro", Value = operadorDTO.fechaRegistro });
                parameters.Add(new SqlParameter { ParameterName = "@puesto", Value = operadorDTO.puesto });
                parameters.Add(new SqlParameter { ParameterName = "@capacitadoChofer", Value = operadorDTO.capacitadoChofer });
                parameters.Add(new SqlParameter { ParameterName = "@estatus", Value = operadorDTO.estatus });
                parameters.Add(new SqlParameter { ParameterName = "@motivo", Value = operadorDTO.motivo });
                parameters.Add(new SqlParameter { ParameterName = "@descripcion", Value = operadorDTO.descripcion });
                parameters.Add(new SqlParameter { ParameterName = "@fechaMotivo", Value = operadorDTO.fechaMotivo });
                parameters.Add(new SqlParameter { ParameterName = "@fotografia", Value = operadorDTO.fotografia });
                parameters.Add(new SqlParameter { ParameterName = "@placas", Value = operadorDTO.placas });
                parameters.Add(new SqlParameter { ParameterName = "@tipoUnidad", Value = operadorDTO.tipoUnidad });

                var ds = DALHelper.Retrive("Operador_insertar", parameters);

                idOperador = OperadorMapper.OperadorDStoOperadorID(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return idOperador;
        }
        public OperadorDTO Editar(OperadorDTO operadorDTO, int idOperador)
        {
            OperadorDTO dto = new OperadorDTO();
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@idOperador", Value = idOperador });
                parameters.Add(new SqlParameter { ParameterName = "@calle", Value = operadorDTO.calle });
                parameters.Add(new SqlParameter { ParameterName = "@numero", Value = operadorDTO.numero });
                parameters.Add(new SqlParameter { ParameterName = "@colonia", Value = operadorDTO.colonia });
                parameters.Add(new SqlParameter { ParameterName = "@municipio", Value = operadorDTO.municipio });
                parameters.Add(new SqlParameter { ParameterName = "@estado", Value = operadorDTO.estado });
                parameters.Add(new SqlParameter { ParameterName = "@cp", Value = operadorDTO.cp });
                parameters.Add(new SqlParameter { ParameterName = "@noCredencialElector", Value = operadorDTO.noCredencialElector });
                parameters.Add(new SqlParameter { ParameterName = "@fechaVigenciaLicencia", Value = operadorDTO.fechaVigenciaLicencia });
                parameters.Add(new SqlParameter { ParameterName = "@noLicencia", Value = operadorDTO.noLicencia });
                parameters.Add(new SqlParameter { ParameterName = "@padecimientos", Value = operadorDTO.padecimientos });
                parameters.Add(new SqlParameter { ParameterName = "@curp", Value = operadorDTO.curp });
                parameters.Add(new SqlParameter { ParameterName = "@noIMSS", Value = operadorDTO.noIMSS });
                parameters.Add(new SqlParameter { ParameterName = "@estatusConfidencialidad", Value = operadorDTO.estatusConfiabilidad });
                parameters.Add(new SqlParameter { ParameterName = "@motivoRechazo", Value = operadorDTO.motivoRechazo });
                parameters.Add(new SqlParameter { ParameterName = "@fechaRegistro", Value = operadorDTO.fechaRegistro });
                parameters.Add(new SqlParameter { ParameterName = "@puesto", Value = operadorDTO.puesto });
                parameters.Add(new SqlParameter { ParameterName = "@capacitadoChofer", Value = operadorDTO.capacitadoChofer });
                parameters.Add(new SqlParameter { ParameterName = "@estatus", Value = operadorDTO.estatus });
                parameters.Add(new SqlParameter { ParameterName = "@motivo", Value = operadorDTO.motivo });
                parameters.Add(new SqlParameter { ParameterName = "@descripcion", Value = operadorDTO.descripcion });
                parameters.Add(new SqlParameter { ParameterName = "@fechaMotivo", Value = operadorDTO.fechaMotivo });
                parameters.Add(new SqlParameter { ParameterName = "@fotografia", Value = operadorDTO.fotografia });
                parameters.Add(new SqlParameter { ParameterName = "@placas", Value = operadorDTO.placas });
                parameters.Add(new SqlParameter { ParameterName = "@tipoUnidad", Value = operadorDTO.tipoUnidad });

                var ds = DALHelper.Retrive("Operador_editar", parameters);

                dto = OperadorMapper.OperadorDStoDTO(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dto;
        }

    }

}