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
    //DOMAIN SE ENCARGA DE VALIDACIONES, GUARDADO DETALLE, EXCEPCIONES, CONSUMIR INTERFAZ
    public class FleteroDomainObject : IFleteroDomainObject
    {
        public int AgregarTiendasFletero(int fletero, int tienda)
        {
            int ID = 0;
            try
            {
                FleteroDAO dao = new FleteroDAO();
                ID = dao.AgregarTiendasFletero(fletero, tienda);

            }catch (Exception ex)
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
                FleteroDAO dao = new FleteroDAO();
                ID = dao.DeshabilitarFletero(fletero, mdto);
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
                FleteroDAO dao = new FleteroDAO();
                ID = dao.HabilitarFletero(fletero, mdto);
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
                FleteroDAO dao = new FleteroDAO();
                ID = dao.ModificarFletero(fdto);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ID;
        }

        public List<FleteroDTO> ObtenerFletero(int fletero)
        {
            List<FleteroDTO> lista = new List<FleteroDTO>();
            try
            {
                FleteroDAO dao = new FleteroDAO();
                lista = dao.ObtenerFletero(fletero);
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
                FleteroDAO dao = new FleteroDAO();
                lista = dao.ObtenerFleteroFiltros(idDistrito,idTienda,idFletero,idEstado);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }

        public FleteroDTO ObtenerFleteroInfoDetallada(int fletero)
        {
            FleteroDTO lista = new FleteroDTO();
            try
            {
                FleteroDAO dao = new FleteroDAO();
                lista = dao.ObtenerFleteroInfoDetallada(fletero);
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
                FleteroDAO dao = new FleteroDAO();
                lista = dao.ObtenerFleteroInfoGeneral();
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
                FleteroDAO dao = new FleteroDAO();
                ID = dao.RegistrarFletero(fdto);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ID;
        }
    }
}
