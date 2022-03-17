using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public class TipoCarroceriaMapper
    {
        public static List<TipoCarroceriaDTO> CarroceriaDSToList(DataSet ds)
        {
            List<TipoCarroceriaDTO> lst = new List<TipoCarroceriaDTO>();

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                var carroceria = new TipoCarroceriaDTO();
                carroceria.IdCarroceria = Convert.ToInt32(row["idCarroceria"]);
                carroceria.TipoCarroceria = Convert.ToString(row["tipoCarroceria"]);

                lst.Add(carroceria);
            }
            return lst;
        }
    }
}
