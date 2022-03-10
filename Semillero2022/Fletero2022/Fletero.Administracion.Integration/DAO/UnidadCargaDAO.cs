using Fletero.Administracion.Integration.DAO.Mapper;
using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Helper
{
    public class UnidadCargaDAO
    {
        public int GuardarUnidad(UnidadCargaDTO unidadDTO)
        {
            int iD = 0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "IdUnidad", Value = 1 });
                parameters.Add(new SqlParameter { ParameterName = "Fletero", Value = unidadDTO.Fletero});
                parameters.Add(new SqlParameter { ParameterName = "Permiso", Value = unidadDTO.Permiso});
                parameters.Add(new SqlParameter { ParameterName = "TipoUnidad", Value = unidadDTO.TipoUnidad});
                parameters.Add(new SqlParameter { ParameterName = "Numero_eco", Value = unidadDTO.Numero_eco});
                parameters.Add(new SqlParameter { ParameterName = "TipoCarroceria", Value = unidadDTO.TipoCarroceria});
                parameters.Add(new SqlParameter { ParameterName = "Marca", Value = unidadDTO.Marca});
                parameters.Add(new SqlParameter { ParameterName = "Modelo", Value = unidadDTO.Modelo});
                parameters.Add(new SqlParameter { ParameterName = "Largo", Value = unidadDTO.Largo});
                parameters.Add(new SqlParameter { ParameterName = "Ancho", Value = unidadDTO.Ancho});
                parameters.Add(new SqlParameter { ParameterName = "Alto", Value = unidadDTO.Alto});
                parameters.Add(new SqlParameter { ParameterName = "Peso", Value = unidadDTO.Peso});
                parameters.Add(new SqlParameter { ParameterName = "PolizaSeguro", Value = unidadDTO.PolizaSeguro});
                parameters.Add(new SqlParameter { ParameterName = "Placas", Value = unidadDTO.Placas});
                parameters.Add(new SqlParameter { ParameterName = "Caract_especial", Value = unidadDTO.Caract_especial});
                parameters.Add(new SqlParameter { ParameterName = "GPS", Value = unidadDTO.GPS });

                var ds = DALHelper.Retrive("Unidad_Agregar", parameters);

                iD = UnidadMapper.UnidadDStoUnidadID_Registrar(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return iD;
        }

        public int EditarUnidad(UnidadCargaDTO unidadDTO)
        {
            int iD = 0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@IdUnidad", Value = 2 });
                parameters.Add(new SqlParameter { ParameterName = "@Fletero", Value = unidadDTO.Fletero });
                parameters.Add(new SqlParameter { ParameterName = "@Permiso", Value = unidadDTO.Permiso });
                parameters.Add(new SqlParameter { ParameterName = "@TipoUnidad", Value = unidadDTO.TipoUnidad });
                parameters.Add(new SqlParameter { ParameterName = "@Numero_eco", Value = unidadDTO.Numero_eco });
                parameters.Add(new SqlParameter { ParameterName = "@TipoCarroceria", Value = unidadDTO.TipoCarroceria });
                parameters.Add(new SqlParameter { ParameterName = "@Marca", Value = unidadDTO.Marca });
                parameters.Add(new SqlParameter { ParameterName = "@Modelo", Value = unidadDTO.Modelo });
                parameters.Add(new SqlParameter { ParameterName = "@Largo", Value = unidadDTO.Largo });
                parameters.Add(new SqlParameter { ParameterName = "@Ancho", Value = unidadDTO.Ancho });
                parameters.Add(new SqlParameter { ParameterName = "@Alto", Value = unidadDTO.Alto });
                parameters.Add(new SqlParameter { ParameterName = "@Peso", Value = unidadDTO.Peso });
                parameters.Add(new SqlParameter { ParameterName = "@PolizaSeguro", Value = unidadDTO.PolizaSeguro });
                parameters.Add(new SqlParameter { ParameterName = "@Placas", Value = unidadDTO.Placas });
                parameters.Add(new SqlParameter { ParameterName = "@Caract_especial", Value = unidadDTO.Caract_especial });
                parameters.Add(new SqlParameter { ParameterName = "@GPS", Value = unidadDTO.GPS });

                var ds = DALHelper.Retrive("Unidad_Editar");

                iD = UnidadMapper.UnidadDStoUnidadID_Registrar(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return iD;
        }

        public List<UnidadCargaDTO> ObtenerUnidad(int idUnidad)
        {
            List<UnidadCargaDTO> unidadList = new List<UnidadCargaDTO>();
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "IdUnidad", Value= 0 });

                var ds = DALHelper.Retrive("Unidad_Buscar");
                unidadList = UnidadMapper.UnidadDSToList_Obtener(ds);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return unidadList;
        }
    }
}
