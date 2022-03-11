using Fletero.Administracion.Services.Contracs.DomainObject;
using Fletero.Administracion.Services.Contracs.DTO;
using Fletero.Administracion.Services.Contracs.Manager;
using Fletero.Administracion.Services.DomainObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.Manager
{
    public class TiendaManager: ITiendaManager
    {
        public List<TiendaDTO> ObtenerTiendas(int id){
            List<TiendaDTO> lista = new List<TiendaDTO>();

            try
            {
                ITiendaDomainObject domain = new TiendaDomainObject();
                lista = domain.ObtenerTiendas(id);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }
    }
}
