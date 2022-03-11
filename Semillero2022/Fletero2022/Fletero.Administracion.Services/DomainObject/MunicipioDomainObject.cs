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
    public class MunicipioDomainObject : IMunicipioDomainObject
    {
        public List<MunicipioDTO> ObtenerMunicipio(int id)
        {
            List<MunicipioDTO> lista = new List<MunicipioDTO>();
            try
            {
                MunicipioDAO dao = new MunicipioDAO();
                lista = dao.ObtenerMunicipio(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }
    }
}
