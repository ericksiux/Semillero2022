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
    public class TipoCarroceriaManager: ITipoCarroceriaManager
    {
        public List<TipoCarroceriaDTO> ObtenerTipoCarroceria(int id)
        {
            List<TipoCarroceriaDTO> lista = new List<TipoCarroceriaDTO>();

            try
            {
                ITipoCarroceriaDomainObject domain = new TipoCarroceriaDomainObject();
                lista = domain.ObtenerTipoCarroceria(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }
    }
}
