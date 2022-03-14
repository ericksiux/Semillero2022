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
    public class EstadoManager : IEstadoManager
    {
        public List<EstadoDTO> ObtenerEstado()
        {

            List<EstadoDTO> lista = new List<EstadoDTO>();

            try
            {
                IEstadoDomainObject domain = new EstadoDomainObject();
                lista = domain.ObtenerEstado();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }
    }
}
