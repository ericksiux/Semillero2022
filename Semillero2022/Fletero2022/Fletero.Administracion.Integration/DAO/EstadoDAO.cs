using Fletero.Administracion.Integration.DAO.Helper;
using Fletero.Administracion.Integration.DAO.Mapper;
using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO
{
    public class EstadoDAO
    {
        public List<EstadoDTO> ObtenerEstados()
        {
            List<EstadoDTO> lst = new List<EstadoDTO>();

            try
            {
                var ds = DALHelper.Retrive("Estado_Consulta");
                lst = EstadoMapper.EstadoDSToList(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lst;
        }
    }
}
