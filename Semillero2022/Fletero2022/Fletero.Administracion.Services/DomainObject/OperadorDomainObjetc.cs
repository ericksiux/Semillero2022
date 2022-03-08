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
    public class OperadorDomainObject: IOperadorDomainObject
    {
        public List<OperadorDTO> ObtenerOperadorList()
        {
            List<OperadorDTO> operadorList = new List<OperadorDTO>();

            try
            {
                operadorDAO DAO = new operadorDAO();

                operadorList = DAO.ObtenerOperadorList();

                foreach (var item in operadorList)
                {
                    Console.Write(string.Format("idOperador : {0}", item.idOperador));
                }

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
                operadorDAO DAO = new operadorDAO();

                idOperador = DAO.Guardar(operadorDTO);

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
                operadorDAO DAO = new operadorDAO();

                dto = DAO.Editar(operadorDTO, idOperador);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dto;
        }
    }
}
