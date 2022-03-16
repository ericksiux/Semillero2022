using Fletero.Administracion.Services.Contracs.DomainObject;
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
    public class UnidadManager : IUnidadManager
    {
        public List<UnidadCargaDTO> ObtenerUnidadList()
        {
            List<UnidadCargaDTO> unidadList = new List<UnidadCargaDTO>();

            try
            {
                IUnidadDomainObject domain = new UnidadDomainObject();

                unidadList = domain.ObtenerUnidadList();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return unidadList;
        }

        public int RegistrarUnidad(UnidadCargaDTO unidadDTO)
        {
            int ID = 0;

            try
            {
                IUnidadDomainObject domain = new UnidadDomainObject();
                ID = domain.RegistrarUnidad(unidadDTO);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ID;
        }
    }

}
