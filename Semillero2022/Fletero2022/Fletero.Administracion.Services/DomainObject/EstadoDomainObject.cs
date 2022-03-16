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
    public class EstadoDomainObject : IEstadoDomainObject
    {
        public List<EstadoDTO> ObtenerEstado()
        {
            List<EstadoDTO> lista = new List<EstadoDTO>();
            try
            {
                EstadoDAO dao = new EstadoDAO();
                lista = dao.ObtenerEstados();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }
    }
}
