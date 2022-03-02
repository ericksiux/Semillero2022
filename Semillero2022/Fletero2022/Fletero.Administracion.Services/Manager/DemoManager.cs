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
    public class DemoManager : IDemoManager
    {
        public List<DemoDTO> ObtenerDemoList()
        {
            List<DemoDTO> demoList = new List<DemoDTO>();

            try
            {
                DemoDomainObject domain = new DemoDomainObject();

                demoList = domain.ObtenerDemoList();

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
                DemoDomainObject domain = new DemoDomainObject();

                demoID = domain.Guardar(demoDTO);

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
                DemoDomainObject domain = new DemoDomainObject();

                dto = domain.Editar(demoDTO);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dto;
        }
    }
}
