using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.Contracs.DomainObject
{
    public interface IContratoDomainObject
    {
        List<ContratoDTO> ObtenerContrato();
        int Guardar(ContratoDTO ContratoDTO);

        ContratoDTO Editar(ContratoDTO ContratoDTO);
        int Guardar(ContratoDTO ContratoDTO);
    }
}
