using Fletero.Administracion.Integration.DAO;
using Fletero.Administracion.Services.Contracs.DomainObject;
using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;

namespace Fletero.Administracion.Services.DomainObject
{
    public class ContratoDomainObject : IContratoDomainObject
    {
        public IEnumerable<ContratoDTO> ObtenerContrato(int contrato)
        {
            IEnumerable<ContratoDTO> listacontrato = null;
            try
            {
                ContratoDAO dao = new ContratoDAO();
                listacontrato = dao.ObtenerContrato(contrato);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listacontrato;
        }

        public int Guardar(ContratoDTO ContratoDTO)
        {
            int idContrato = 0;

            try
            {
                ContratoDAO DAO = new ContratoDAO();

                idContrato = DAO.Guardar(ContratoDTO);

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
                ContratoDAO DAO = new ContratoDAO();

                dto = DAO.Editar(ContratoDTO);

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
    }
}