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
    public class DistritoDAO
    {
        public List<DistritoDTO> ObtenerDistritos()
        {
            List<DistritoDTO> lst = new List<DistritoDTO>();

            try
            {
                var ds = DALHelper.Retrive("Distrito_Consulta");
                lst = DistritoMapper.DistritoDSToList(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lst;
        }
    }
}
