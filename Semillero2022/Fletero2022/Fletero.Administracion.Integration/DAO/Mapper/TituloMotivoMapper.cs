using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public class TituloMotivoMapper
    {
        public static List<TituloMotivoDTO> TituloListDStoList(DataSet ds)
        {
            List<TituloMotivoDTO> lista = new List<TituloMotivoDTO>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var lst = new TituloMotivoDTO();
                lst.idMotivoM = Convert.ToInt32(row["idTituloM"]);
                lst.motivo = Convert.ToString(row["motivo"]);

                lista.Add(lst);
            }

            return lista;
        }
    }
}
