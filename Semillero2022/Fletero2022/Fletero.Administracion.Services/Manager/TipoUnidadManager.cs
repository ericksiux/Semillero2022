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
    public class TipoUnidadManager: ITipoUnidadManager
    {
        public List<TipoUnidadDTO> ObtenerTipoUnidad(int id)
        {
            List<TipoUnidadDTO> lista = new List<TipoUnidadDTO>();

            try
            {
                ITipoUnidadDomainObject domain = new TipoUnidadDomainObject();
                lista = domain.ObtenerTipoUnidad(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }
    }
}
