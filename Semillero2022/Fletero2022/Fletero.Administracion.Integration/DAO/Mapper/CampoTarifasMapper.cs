using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public class CampoTarifasMapper
    {
        public static CamposTarifasDTO CamposTarifasDTO(DataSet ds)
        {
            CamposTarifasDTO campotarifa = new CamposTarifasDTO();

            if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                campotarifa.idCampoTarifa = Convert.ToInt32(ds.Tables[0].Rows[0]["idCampoTarifa"]);
                campotarifa.metodoPagoLocal = Convert.ToBoolean(ds.Tables[0].Rows[0]["metodoPagoLocal"]);
                campotarifa.tarifaRentaDiaria = Convert.ToDecimal(ds.Tables[0].Rows[0]["tarifaRentaDiaria"]);
                campotarifa.distanciaZonaLocal = Convert.ToInt32(ds.Tables[0].Rows[0]["distanciaZonaLocal"]);
                campotarifa.horasLaboral = Convert.ToInt32(ds.Tables[0].Rows[0]["horasLaboral"]);
                campotarifa.tarifaHoraExtra = Convert.ToDecimal(ds.Tables[0].Rows[0]["tarifaHoraExtra"]);
                campotarifa.tarifaEntregaLocal = Convert.ToDecimal(ds.Tables[0].Rows[0]["tarifaEntregaLocal"]);
                campotarifa.tarifaVueltaLocal = Convert.ToDecimal(ds.Tables[0].Rows[0]["tarifaVueltaLocal"]);
                campotarifa.tarifaReparto = Convert.ToDecimal(ds.Tables[0].Rows[0]["tarifaReparto"]);
                campotarifa.incluyeManiobra = Convert.ToBoolean(ds.Tables[0].Rows[0]["incluyeManiobra"]);
                campotarifa.unidadCarga = Convert.ToInt32(ds.Tables[0].Rows[0]["unidadCarga"]);
            }

            return campotarifa;
        }

        public static int CampoTarifasDStoCampoTarifasID(DataSet ds)
        {
            if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["idCampoTarifa"]);
            }

            return 0;
        }
    }
}
