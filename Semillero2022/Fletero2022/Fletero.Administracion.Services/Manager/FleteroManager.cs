using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fletero.Administracion.Services.Contracs.DomainObject;
using Fletero.Administracion.Services.Contracs.DTO;
using Fletero.Administracion.Services.Contracs.Manager;
using Fletero.Administracion.Services.DomainObject;


namespace Fletero.Administracion.Services.Manager
{
    public class FleteroManager : IFleteroManager
    {
        public int AgregarTiendasFletero(int fletero, int tienda)
        {
            int ID = 0;

            try
            {
                //está creando una instancia de algo que implementa la interfaz.
                IFleteroDomainObject domain = new FleteroDomainObject();
                ID = domain.AgregarTiendasFletero(fletero, tienda);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ID;
        }

        public int DeshabilitarFletero(int fletero, MotivoDTO mdto)
        {
            int ID = 0;

            try
            {
                IFleteroDomainObject domain = new FleteroDomainObject();
                ID = domain.DeshabilitarFletero(fletero, mdto);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ID;
        }

        public int HabilitarFletero(int fletero, MotivoDTO mdto)
        {
            int ID = 0;

            try
            {
                IFleteroDomainObject domain = new FleteroDomainObject();
                ID = domain.HabilitarFletero(fletero, mdto);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ID;
        }

        public int ModificarFletero(FleteroDTO fdto)
        {
            int ID = 0;

            try
            {
                IFleteroDomainObject domain = new FleteroDomainObject();
                ID = domain.ModificarFletero(fdto);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ID;
        }

        public List<FleteroDTO> ObtenerFletero(int fletero)
        {
            List <FleteroDTO> lista = new List <FleteroDTO>();

            try
            {
                IFleteroDomainObject domain = new FleteroDomainObject();
                lista = domain.ObtenerFletero(fletero);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }

        public List<FleteroDTO> ObtenerFleteroFiltros(int? idDistrito, int? idTienda, int? idFletero, int? idEstado)
        {
            List<FleteroDTO> lista = new List<FleteroDTO>();

            try
            {
                IFleteroDomainObject domain = new FleteroDomainObject();
                lista = domain.ObtenerFleteroFiltros(idDistrito, idTienda, idFletero, idEstado);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }

        public List<FleteroDTO> ObtenerFleteroInfoDetallada(int fletero)
        {
            List<FleteroDTO> lista = new List<FleteroDTO>();

            try
            {
                IFleteroDomainObject domain = new FleteroDomainObject();
                lista = domain.ObtenerFleteroInfoDetallada(fletero);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }

        public List<FleteroDTO> ObtenerFleteroInfoGeneral()
        {
            List<FleteroDTO> lista = new List<FleteroDTO>();

            try
            {
                IFleteroDomainObject domain = new FleteroDomainObject();
                lista = domain.ObtenerFleteroInfoGeneral();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }

        public int RegistrarFletero(FleteroDTO fdto)
        {
            int ID = 0;

            try
            {
                IFleteroDomainObject domain = new FleteroDomainObject();
                ID = domain.RegistrarFletero(fdto);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ID;
        }
    }
}
