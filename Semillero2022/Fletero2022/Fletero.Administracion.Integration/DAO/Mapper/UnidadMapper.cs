using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public class UnidadMapper
    {
        public static int UnidadDStoUnidadID_Registrar(DataSet ds)
        {
            if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["IdUnidad"]);
            }
            return 0;
        }

        public static List<UnidadCargaDTO> UnidadDSToList_Obtener(DataSet ds)
        {
            List<UnidadCargaDTO> unidad = new List<UnidadCargaDTO>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var unidades = new UnidadCargaDTO();

                unidades.Fletero = Convert.ToInt32(row["Fletero"]);
                unidades.Permiso = Convert.ToInt32(row["Permiso"]);
                unidades.TipoUnidad = Convert.ToInt32(row["TipoUnidad"]);
                unidades.Numero_eco = Convert.ToString(row["Numero_eco"]);
                unidades.TipoCarroceria = Convert.ToInt32(row["TipoCarroceria"]);
                unidades.Marca = Convert.ToString(row["Marca"]);
                unidades.Modelo = Convert.ToString(row["Modelo"]);
                unidades.Largo = Convert.ToString(row["Largo"]);
                unidades.Ancho = Convert.ToString(row["Ancho"]);
                unidades.Peso = Convert.ToInt32(row["Peso"]);
                unidades.PolizaSeguro = Convert.ToInt32(row["PolizaSeguro"]);
                unidades.Placas = Convert.ToInt32(row["Placas"]);
                unidades.Caract_especial = Convert.ToString(row["Caract_especial"]);
                unidades.GPS = Convert.ToBoolean(row["GPS"]);

                unidad.Add(unidades);
            }

            return unidad;
        }
        
    }
}
