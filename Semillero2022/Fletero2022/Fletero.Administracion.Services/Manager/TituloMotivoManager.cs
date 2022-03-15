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
    public class TituloMotivoManager : ITituloMotivoManager
    {
        public List<TituloMotivoDTO> ObtenerTituloMotivos()
        {
            List<TituloMotivoDTO> lista = new List<TituloMotivoDTO>();

            try
            {
                ITituloMotivoDomainObject domain = new TituloMotivoDomainObject();
                lista = domain.ObtenerTituloMotivos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }
    }
}
