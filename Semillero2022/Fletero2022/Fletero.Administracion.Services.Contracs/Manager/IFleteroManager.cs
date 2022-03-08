using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fletero.Administracion.Services.Contracs.DTO;

namespace Fletero.Administracion.Services.Contracs.Manager
{
    public interface IFleteroManager
    {
        int RegistrarFletero(FleteroDTO fdto);
        int ModificarFletero(FleteroDTO fdto);
        int HabilitarFletero(int fletero, MotivoDTO mdto);
        int DeshabilitarFletero(int fletero, MotivoDTO mdto);
        int AgregarTiendasFletero(int fletero, int tienda);
        List<FleteroDTO> ObtenerFletero(int fletero);
        List<FleteroDTO> ObtenerFleteroInfoGeneral();
        List<FleteroDTO> ObtenerFleteroInfoDetallada(int fletero);
        List<FleteroDTO> ObtenerFleteroFiltros(int? idDistrito, int? idTienda, int? idFletero, int? idEstado);
    }
}
