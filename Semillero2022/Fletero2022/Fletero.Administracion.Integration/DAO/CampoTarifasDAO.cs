using Fletero.Administracion.Integration.DAO.Helper;
using Fletero.Administracion.Integration.DAO.Mapper;
using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO
{
    public class CampoTarifasDAO
    {
        public int Guardar(CamposTarifasDTO CamposTarifasDTO, int idCampoTarifa)
        {
            int idCampoTarifa = 0;
            try
            {
                IList<IDbDataParameter> parameters = new List<IDbDataParameter>();
                parameters.Add(new SqlParameter { ParameterName = "@pIdCampoTarifa", Value = idCampoTarifa });
                parameters.Add(new SqlParameter { ParameterName = "@pMetodoPagoLocal", Value = CamposTarifasDTO.metodoPagoLocal });
                parameters.Add(new SqlParameter { ParameterName = "@pTarifaRentaDiaria", Value = CamposTarifasDTO.tarifaRentaDiaria });
                parameters.Add(new SqlParameter { ParameterName = "@pDistanciaZonaLocal", Value = CamposTarifasDTO.distanciaZonaLocal });
                parameters.Add(new SqlParameter { ParameterName = "@pHorasLaboral", Value = CamposTarifasDTO.horasLaboral });
                parameters.Add(new SqlParameter { ParameterName = "@pTarifaHoraExtra", Value = CamposTarifasDTO.tarifaHoraExtra });
                parameters.Add(new SqlParameter { ParameterName = "@pTarifaEntregaLocal", Value = CamposTarifasDTO.tarifaEntregaLocal });
                parameters.Add(new SqlParameter { ParameterName = "@pTarifaVueltaLocal", Value = CamposTarifasDTO.tarifaVueltaLocal });
                parameters.Add(new SqlParameter { ParameterName = "@pTarifaReparto", Value = CamposTarifasDTO.tarifaReparto });
                parameters.Add(new SqlParameter { ParameterName = "@pIncluyeManiobra", Value = CamposTarifasDTO.incluyeManiobra });
                parameters.Add(new SqlParameter { ParameterName = "@pUnidadCarga", Value = CamposTarifasDTO.unidadCarga });

                var ds = DALHelper.Retrive("CamposTarifas_Insertar", parameters);

                idCampoTarifa = CampoTarifasMapper.CampoTarifasDStoCampoTarifasID(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return idCampoTarifa;
        }
    }
}
