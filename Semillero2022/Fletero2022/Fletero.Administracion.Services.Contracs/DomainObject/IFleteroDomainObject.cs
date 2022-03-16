using System;
using Fletero.Administracion.Services.Contracs.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.Contracs.DomainObject
{
    public interface IFleteroDomainObject
    {
        int RegistrarFletero(FleteroDTO fdto);
        int ModificarFletero(FleteroDTO fdto);
        int HabilitarFletero(int fletero, MotivoDTO mdto);
        int DeshabilitarFletero(int fletero, MotivoDTO mdto);
        int AgregarTiendasFletero(int fletero, int tienda);
        List<FleteroDTO> ObtenerFletero(int fletero);
        List<FleteroDTO> ObtenerFleteroInfoGeneral();
        FleteroDTO ObtenerFleteroInfoDetallada(int fletero);
        List<FleteroDTO> ObtenerFleteroFiltros(int? idDistrito, int? idTienda, int? idFletero, int? idEstado);
    }
}
