using Fletero.Administracion.Integration.DAO.Helper;
using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public class TiendaMapper
    {
        public static List<TiendaDTO> TiendaDSToList(DataSet ds)
        {
            List<TiendaDTO> lst = new List<TiendaDTO>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var tienda = new TiendaDTO();
                tienda.IDSTORE = Convert.ToInt32(row["IDSTORE"]);
                tienda.STORENAME = Convert.ToString(row["STORENAME"]);
                tienda.IDDISTRICTFK = Convert.ToInt32(row["IDDISTRICT"]);

                lst.Add(tienda);
            }
            return lst;
        }
    }
}
