using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public class MunicipioMapper
    {
        public static List<MunicipioDTO> MunicipioDSToList(DataSet ds)
        {
            List<MunicipioDTO> lst = new List<MunicipioDTO>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var mun = new MunicipioDTO();
                mun.ID_MUNICIPIO = Convert.ToInt32(row["ID_MUNICIPIO"]);
                mun.NOMBRE = Convert.ToString(row["NOMBRE"]);
                mun.ID_ESTADOFK = Convert.ToInt32(row["ID_ESTADO"]);

                lst.Add(mun);
            }
            return lst;
        }
    }
}
