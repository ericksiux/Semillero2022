using Fletero.Administracion.Integration.DAO.Mapper;
using Fletero.Administracion.Services.Contracs.DomainObject;
using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.DomainObject
{
    public class TipoUnidadDomainObject: ITipoUnidadDomainObject
    {
        public List<TipoUnidadDTO> ObtenerTipoUnidad(int id)
        {
            List<TipoUnidadDTO> lista = new List<TipoUnidadDTO>();
            try
            {
                TipoUnidadDAO dao = new TipoUnidadDAO();
                lista = dao.ObtenerTipoUnidad(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }
    }
}
