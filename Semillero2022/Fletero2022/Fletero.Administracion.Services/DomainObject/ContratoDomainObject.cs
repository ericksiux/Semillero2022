using Fletero.Administracion.Integration.DAO;
using Fletero.Administracion.Services.Contracs.DomainObject;
using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;

namespace Fletero.Administracion.Services.DomainObject
{
    public class ContratoDomainObject : IContratoDomainObject
    {
        public List<ContratoDTO> ObtenerContrato()
        {
            List<ContratoDTO> ContratoList = new List<ContratoDTO>();

            try
            {
                ContratoDAO DAO = new ContratoDAO();

                ContratoList = DAO.ObtenerContrato();

                foreach (var item in ContratoList)
                {
                    Console.Write(string.Format("idContrato : {0}", item.idContrato));
                }

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