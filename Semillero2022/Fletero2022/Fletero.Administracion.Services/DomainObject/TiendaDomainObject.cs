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
    public class TiendaDomainObject: ITiendaDomainObject
    {
        public List<TiendaDTO> ObtenerTiendas(int id)
        {
            List<TiendaDTO> lista = new List<TiendaDTO>();
            try
            {
                TiendaDAO dao = new TiendaDAO();
                lista = dao.ObtenerTiendas(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }
    }
}
