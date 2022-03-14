using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public class EstadoMapper
    {
        public static List<EstadoDTO> EstadoDSToList(DataSet ds)
        {
            List<EstadoDTO> lst = new List<EstadoDTO>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var estado = new EstadoDTO();
                estado.ID_ESTADO = Convert.ToInt32(row["ID_ESTADO"]);
                estado.NOMBRE= Convert.ToString(row["NOMBRE"]);

                lst.Add(estado);
            }
            return lst;
        }
    }
}
