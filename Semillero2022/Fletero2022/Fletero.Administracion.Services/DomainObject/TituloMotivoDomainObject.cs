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
    public class TituloMotivoDomainObject : ITituloMotivoDomainObject
    {
        public List<TituloMotivoDTO> ObtenerTituloMotivos()
        {
            List<TituloMotivoDTO> lista = new List<TituloMotivoDTO>();
            try
            {
                FleteroDAO dao = new FleteroDAO();
                lista = dao.ObtenerTituloMotivos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;

        }
    }
}
