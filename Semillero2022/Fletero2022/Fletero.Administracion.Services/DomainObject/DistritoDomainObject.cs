using Fletero.Administracion.Integration.DAO;
using Fletero.Administracion.Services.Contracs.DomainObject;
using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.DomainObject
{
    public class DistritoDomainObject : IDistritoDomainObject
    {
        public List<DistritoDTO> ObtenerDistritos()
        {
            List<DistritoDTO> lista = new List<DistritoDTO>();
            try
            {
                DistritoDAO dao = new DistritoDAO();
                lista = dao.ObtenerDistritos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
            
        }
    }
}
