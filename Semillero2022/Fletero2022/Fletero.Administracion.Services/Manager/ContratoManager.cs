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
    public class ContratoManager : IContratoManager
    {
        public List<ContratoDTO> ContratoDTO()
        {
            List<ContratoDTO> ContratoList = new List<ContratoDTO>();

            try
            {
                ContratoDomainObject domain = new ContratoDomainObject();

                ContratoList = domain.ObtenerContrato();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ContratoList;
        }

        public int Guardar(ContratoDTO ContratoDTO)
        {
            int idContrato = 0;

            try
            {
                ContratoDomainObject domain = new ContratoDomainObject();

                idContrato = domain.Guardar(ContratoDTO);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return idContrato;
        }

        public ContratoDTO Editar(ContratoDTO ContratoDTO)
        {
            ContratoDTO dto = new ContratoDTO();

            try
            {
                ContratoDomainObject domain = new ContratoDomainObject();

                dto = domain.Editar(ContratoDTO);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dto;
        }

        public List<ContratoDTO> ObtenerContrato()
        {
            throw new NotImplementedException();
        }

        public int Guardar(ContratoDTO ContratoDTO)
        {
            throw new NotImplementedException();
        }

        public ContratoDTO Editar(ContratoDTO ContratoDTO)
        {
            throw new NotImplementedException();
        }
    }
}
