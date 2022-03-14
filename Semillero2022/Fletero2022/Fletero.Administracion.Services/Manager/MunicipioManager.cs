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
    public class MunicipioManager : IMunicipioManager
    {
        public List<MunicipioDTO> ObtenerMunicipio(int id)
        {
            List<MunicipioDTO> lista = new List<MunicipioDTO>();

            try
            {
                IMunicipioDomainObject domain = new MunicipioDomainObject();
                lista = domain.ObtenerMunicipio(id);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }
    }
}
