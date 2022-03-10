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
    public class OperadorManager: IOperadorManager
    {
        public List<OperadorDTO> ObtenerOperadorList()
        {
            List<OperadorDTO> operadorList = new List<OperadorDTO>();

            try
            {
                IOperadorDomainObject domain = new OperadorDomainObject();

                operadorList = domain.ObtenerOperadorList();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return operadorList;
        }
        public int Guardar(OperadorDTO operadorDTO)
        {
            int idOperador = 0;

            try
            {
                OperadorDomainObject domain = new OperadorDomainObject();

                idOperador = domain.Guardar(operadorDTO);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return idOperador;
        }
        public OperadorDTO Editar(OperadorDTO operadorDTO, int idOperador)
        {
            OperadorDTO dto = new OperadorDTO();

            try
            {
                OperadorDomainObject domain = new OperadorDomainObject();

                dto = domain.Editar(operadorDTO, idOperador);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dto;
        }
    }
}
