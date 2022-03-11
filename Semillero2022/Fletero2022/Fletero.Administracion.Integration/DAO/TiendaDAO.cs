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
    public class TiendaDAO
    {
        public List<TiendaDTO> ObtenerTiendas(int id)
        {
            List<TiendaDTO> lst = new List<TiendaDTO>();

            try
            {

                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });

                var ds = DALHelper.Retrive("Tienda_Consulta", parameters);
                lst = TiendaMapper.TiendaDSToList(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lst;
        }
    }
}
