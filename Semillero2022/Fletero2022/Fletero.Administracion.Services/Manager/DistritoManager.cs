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
    public class DistritoManager: IDistritoManager
    {
        public List<DistritoDTO> ObtenerDistritos()
        {
            List<DistritoDTO> lista = new List<DistritoDTO>();

            try
            {
                IDistritoDomainObject domain = new DistritoDomainObject();
                lista = domain.ObtenerDistritos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }
    }
}
