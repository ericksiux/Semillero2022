using Fletero.Administracion.Integration.DAO.Helper;
using Fletero.Administracion.Services.Contracs.DomainObject;
using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.DomainObject
{
    public class UnidadDomainObject: IUnidadDomainObject
    {
        public List<UnidadCargaDTO> ObtenerUnidadList()
        {
            List<UnidadCargaDTO> unidadList = new List<UnidadCargaDTO>();

            try
            {
                UnidadCargaDAO uDAO = new UnidadCargaDAO();

                unidadList = uDAO.ObtenerUnidad(0);

                foreach (var item in unidadList)
                {
                    Console.Write(string.Format("Fletero : {0}", item.Fletero));
                    Console.Write(String.Format("Permiso : {1}", item.Permiso));
                    Console.Write(String.Format("TipoUnidad : {2}", item.TipoUnidad));
                    Console.Write(String.Format("Numero_eco : {3}", item.Numero_eco));
                    Console.Write(String.Format("TipoCarroceria : {4}", item.TipoCarroceria));
                    Console.Write(String.Format("Marca : {5}", item.Marca));
                    Console.Write(String.Format("Modelo : {6}", item.Modelo));
                    Console.Write(String.Format("Largo : {7}", item.Largo));
                    Console.Write(String.Format("Ancho : {8}", item.Ancho));
                    Console.Write(String.Format("Alto : {9}", item.Alto));
                    Console.Write(String.Format("Peso : {10}", item.Peso));
                    Console.Write(String.Format("PolizaSeguro : {11}", item.PolizaSeguro));
                    Console.Write(String.Format("Placas : {12}", item.Placas));
                    Console.Write(String.Format("Caract_especial : {13}", item.Caract_especial));
                    Console.Write(String.Format("GPS : {14}", item.GPS));
                }

                //Validaciones

                //Excepciones

                //Guardado detalle

                //Envio correo

                //Consumir interfaz

                //Reglas de negocio

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return unidadList;
        }
        public int RegistrarUnidad(UnidadCargaDTO unidadDTO)
        {
            int unidadID = 0;

            try
            {
                UnidadCargaDAO uDAO = new UnidadCargaDAO();
                unidadID = uDAO.GuardarUnidad(unidadDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return unidadID;
        }

        public int EditarUnidad(UnidadCargaDTO unidadDTO)
        {
            int unidadID = 0;

            try
            {
                UnidadCargaDAO uDAO = new UnidadCargaDAO();

                unidadID = uDAO.EditarUnidad(unidadDTO);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return unidadID;
        }

    }

}
