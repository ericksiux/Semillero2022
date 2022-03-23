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
    public class TipoCarroceriaDomainObject: ITipoCarroceriaDomainObject
    {
        public List<TipoCarroceriaDTO> ObtenerTipoCarroceria(int id)
        {
            List<TipoCarroceriaDTO> lista = new List<TipoCarroceriaDTO>();
            try
            {
                TipoCarroceriaDAO dao = new TipoCarroceriaDAO();
                lista = dao.ObtenerTipoCarroceria(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }
    }
}
