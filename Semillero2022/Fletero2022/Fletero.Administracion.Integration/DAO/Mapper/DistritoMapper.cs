using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public class DistritoMapper
    {
        public static List<DistritoDTO> DistritoDSToList(DataSet ds)
        {
            List<DistritoDTO> lst = new List<DistritoDTO>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var distrito = new DistritoDTO();
                distrito.IDDISTRICT = Convert.ToInt32(row["IDDISTRICT"]);
                distrito.DISTRICTNAME = Convert.ToString(row["DISTRICTNAME"]);

                lst.Add(distrito);
            }
            return lst;
        }
    }
}
