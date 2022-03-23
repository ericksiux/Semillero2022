using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public class TipoUnidadMapper
    {
        public static List<TipoUnidadDTO> TipoUnidadDSToList(DataSet ds)
        {
            List<TipoUnidadDTO> lst = new List<TipoUnidadDTO>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var tipoU = new TipoUnidadDTO();
                tipoU.IdTipoUnidad = Convert.ToInt32(row["idTipoUnidad"]);
                tipoU.NombreUnidad = Convert.ToString(row["nombreUnidad"]);
                tipoU.DescripcionUnidad = Convert.ToString(row["descripcion"]);

                lst.Add(tipoU);
            }
            return lst;
        }
    }
}
