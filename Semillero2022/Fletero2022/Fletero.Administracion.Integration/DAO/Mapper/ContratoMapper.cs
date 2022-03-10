using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public static class ContratoMapper
    {
        public static IEnumerable<ContratoDTO> ContratoDStoList(DataSet ds)
        {
           var contratos = new List<ContratoDTO>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var contrato = new ContratoDTO();

                contrato.idContrato = Convert.ToInt32(row["idContrato"]);
                contrato.lugarFirmaContrato = Convert.ToString(row["lugarFirmaContrato"]);
                contrato.fechaFirmaContrato = Convert.ToDateTime(row["fechaFirmaContrato"]);
                contrato.quienFirmaHomeDepot = Convert.ToString(row["quienFirmaHomeDepot"]);
                contrato.quienFirmaFletero = Convert.ToString(row["quienFirmaFletero"]);
                contrato.quienRealizoFirma = Convert.ToString(row["quienRealizoFirma"]);
                contrato.fechaInicioContrato = Convert.ToDateTime(row["fechaInicioContrato"]);
                contrato.fechaTerminacionContrato = Convert.ToDateTime(row["fechaTerminacionContrato"]);
                contrato.renovacionAutomatica = Convert.ToBoolean(row["renovacionAutomatica"]);
                contrato.IDREGION = Convert.ToInt32(row["IDREGION"]);
                contrato.IDDISTRICT = Convert.ToInt32(row["IDDISTRICT"]);
                contrato.IDSTORE = Convert.ToInt32(row["IDSTORE"]);
                contrato.idFletero = Convert.ToInt32(row["idFletero"]);
                contrato.statusContrato = Convert.ToInt32(row["CampoID"]);
                contrato.idCampoTarifa = Convert.ToInt32(row["idCampoTarifa"]);
                contrato.idArchivo = Convert.ToInt32(row["idArchivo"]);

                contratos.Add(contrato);
            }

            return contratos;
        }

        public static int ContratoDStoidContrato_HabilitarContrato(DataSet ds)
        {
            if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["idmot"]);
            }

            return 0;
        }
        public static int ContratoDStoidContrato_DeshabilitarContrato(DataSet ds)
        {
            if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["idmot"]);
            }

            return 0;
        }

        public static ContratoDTO ContratostoDTO(DataSet ds)
        {
            ContratoDTO contrato = new ContratoDTO();

            if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                contrato.idContrato = Convert.ToInt32(ds.Tables[0].Rows[0]["idContrato"]);
                contrato.lugarFirmaContrato = Convert.ToString(ds.Tables[0].Rows[0]["lugarFirmaContrato"]);
                contrato.fechaFirmaContrato = Convert.ToDateTime(ds.Tables[0].Rows[0]["fechaFirmaContrato"]);
                contrato.quienFirmaHomeDepot = Convert.ToString(ds.Tables[0].Rows[0]["quienFirmaHomeDepot"]);
                contrato.quienFirmaFletero = Convert.ToString(ds.Tables[0].Rows[0]["quienFirmaFletero"]);
                contrato.quienRealizoFirma = Convert.ToString(ds.Tables[0].Rows[0]["quienRealizoFirma"]);
                contrato.fechaInicioContrato = Convert.ToDateTime(ds.Tables[0].Rows[0]["fechaInicioContrato"]);
                contrato.fechaTerminacionContrato = Convert.ToDateTime(ds.Tables[0].Rows[0]["fechaTerminacionContrato"]);
                contrato.renovacionAutomatica = Convert.ToBoolean(ds.Tables[0].Rows[0]["renovacionAutomatica"]);
                contrato.IDREGION = Convert.ToInt32(ds.Tables[0].Rows[0]["IDREGION"]);
                contrato.IDDISTRICT = Convert.ToInt32(ds.Tables[0].Rows[0]["IDDISTRICT"]);
                contrato.IDSTORE = Convert.ToInt32(ds.Tables[0].Rows[0]["IDSTORE"]);
                contrato.idFletero = Convert.ToInt32(ds.Tables[0].Rows[0]["idFletero"]);
                contrato.statusContrato = Convert.ToInt32(ds.Tables[0].Rows[0]["CampoID"]);
                contrato.idCampoTarifa = Convert.ToInt32(ds.Tables[0].Rows[0]["idCampoTarifa"]);
                contrato.idArchivo = Convert.ToInt32(ds.Tables[0].Rows[0]["idArchivo"]);
            }

            return contrato;
        }

        public static int ContratoDStoContratoID(DataSet ds)
        {
            if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["idContrato"]);
            }

            return 0;
        }
    }
}
