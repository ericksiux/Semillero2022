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
    public class DemoDomainObject : IDemoDomainObject
    {
        public List<DemoDTO> ObtenerDemoList()
        {
            List<DemoDTO> demoList = new List<DemoDTO>();

            try
            {
                DemoDAO DAO = new DemoDAO();

                demoList = DAO.ObtenerDemoList();

                foreach(var item in demoList)
                {
                    Console.Write(string.Format("Campo1 : {0}", item.CampoID));
                }

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
                DemoDAO DAO = new DemoDAO();

                demoID = DAO.Guardar(demoDTO);

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
                DemoDAO DAO = new DemoDAO();

                dto = DAO.Editar(demoDTO);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dto;
        }

        //Se agrega comentario
    }
}
