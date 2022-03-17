using Fletero.Administracion.Integration.DAO.Helper;
using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public class TipoUnidadDAO
    {
        public List<TipoUnidadDTO> ObtenerTipoUnidad(int id)
        {
            List<TipoUnidadDTO> lst = new List<TipoUnidadDTO>();

            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@idTipoUnidad", Value = id});

                var ds = DALHelper.Retrive("TipoUnidad_Consulta", parameters);
                lst = TipoUnidadMapper.TipoUnidadDSToList(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lst;
        }
    }
}
