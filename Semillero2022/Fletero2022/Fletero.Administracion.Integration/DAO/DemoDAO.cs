using Fletero.Administracion.Integration.DAO.Helper;
using Fletero.Administracion.Integration.DAO.Mapper;
using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO
{
    public class DemoDAO
    {
        public List<DemoDTO> ObtenerDemoList()
        {
            List<DemoDTO> demoList = new List<DemoDTO>();

            try
            {
                var ds =  DALHelper.Retrive("Demo_Obtener");
                demoList = DemoMapper.DemoDStoList(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return demoList;
        }

        public int Guardar(DemoDTO demoDTO)
        {
            int demoID = 0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@CampoID", Value = demoDTO.CampoID });
                parameters.Add(new SqlParameter { ParameterName = "@Campo2", Value = demoDTO.Campo2 });
                parameters.Add(new SqlParameter { ParameterName = "@Campo4", Value = demoDTO.Campo4 }); 

                var ds = DALHelper.Retrive("Demo_Crear", parameters);

                demoID = DemoMapper.DemoDStoDemoID(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return demoID;
        }

        public DemoDTO Editar(DemoDTO demoDTO)
        {
            DemoDTO dto = new DemoDTO();
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@CampoID", Value = demoDTO.CampoID });
                parameters.Add(new SqlParameter { ParameterName = "@Campo2", Value = demoDTO.Campo2 });
                parameters.Add(new SqlParameter { ParameterName = "@Campo4", Value = demoDTO.Campo4 });

                var ds = DALHelper.Retrive("Demo_Editar");

                dto = DemoMapper.DemoDStoDTO(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dto;
        }
    }
}
