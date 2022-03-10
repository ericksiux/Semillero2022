using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.Contracs.Manager
{
    public interface IUnidadManager
    {
        List<UnidadCargaDTO> ObtenerUnidadList();
        //int GuardarUnidad(UnidadCargaDTO unidadDTO);
        //int EditarUnidad(UnidadCargaDTO unidadDTO);

    }
}
