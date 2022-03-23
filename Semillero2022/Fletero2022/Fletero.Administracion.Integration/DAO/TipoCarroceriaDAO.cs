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
    public class TipoCarroceriaDAO
    {
        public List<TipoCarroceriaDTO> ObtenerTipoCarroceria(int id)
        {
            List<TipoCarroceriaDTO> lst = new List<TipoCarroceriaDTO>();

            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "idCarroceria", Value = id });

                var ds = DALHelper.Retrive("TipoCarroceria_Consulta", parameters);
                lst = TipoCarroceriaMapper.CarroceriaDSToList(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lst;
        }
    }
}
