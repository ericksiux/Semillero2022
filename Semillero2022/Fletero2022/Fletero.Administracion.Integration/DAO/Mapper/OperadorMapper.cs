using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public static class OperadorMapper
    {
        public static List<OperadorDTO> OperadorDStoList(DataSet ds)
        {
            List<OperadorDTO> operadores = new List<OperadorDTO>();

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                var operador = new OperadorDTO();

                operador.distrito = Convert.ToInt32(row["distrito"]);
                operador.fletero = Convert.ToInt32(row["fletero"]);
                operador.unidad = Convert.ToInt32(row["unidad"]);
                operador.nombre = Convert.ToString(row["nombre"]);
                operador.apellidoPat = Convert.ToString(row["apellidoPat"]);
                operador.apellidoMAt = Convert.ToString(row["apellidoMat"]);
                operador.calle = Convert.ToString(row["calle"]);
                operador.numero = Convert.ToInt32(row["numero"]);
                operador.colonia = Convert.ToString(row["colonia"]);
                operador.municipio = Convert.ToString(row["municipio"]);
                operador.estado = Convert.ToString(row["estado"]);
                operador.cp= Convert.ToInt32(row["cp"]);
                operador.noCredencialElector = Convert.ToInt32(row["noCredencialElector"]);
                operador.fechaVigenciaLicencia = Convert.ToString(row["fechaVigenciaLicencia"]);
                operador.noLicencia = Convert.ToInt32(row["noLicencia"]);
                operador.padecimientos = Convert.ToString(row["padecimientos"]);
                operador.curp = Convert.ToString(row["curp"]);
                operador.noIMSS = Convert.ToInt32(row["noIMSS"]);
                operador.estatusConfiabilidad = Convert.ToString(row["estatusConfiabilidad"]);
                operador.motivoRechazo = Convert.ToString(row["motivoRechazo"]);
                operador.fechaRegistro = Convert.ToString(row["fechaRegistro"]);
                operador.puesto = Convert.ToString(row["puesto"]);
                operador.capacitadoChofer = Convert.ToChar(row["capacitadoChofer"]);
                operador.estatus=  Convert.ToString(row["estatus"]);
                operador.motivo = Convert.ToString(row["motivo"]);
                operador.descripcion = Convert.ToString(row["descripcion"]);
                operador.fechaMotivo = Convert.ToString(row["fechaMotivo"]);
                operador.fotografia = Convert.ToString(row["fotografia"]);
                operador.placas = Convert.ToString(row["placas"]);
                operador.tipoUnidad = Convert.ToString(row["tipoUnidad"]);

            }
            return operadores;
        }
        public static OperadorDTO OperadorDStoDTO(DataSet ds)
        {
            OperadorDTO operador = new OperadorDTO();

            if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                operador.distrito = Convert.ToInt32(ds.Tables[0].Rows[0]["distrito"]);
                operador.fletero = Convert.ToInt32(ds.Tables[0].Rows[0]["fletero"]);
                operador.unidad = Convert.ToInt32(ds.Tables[0].Rows[0]["unidad"]);
                operador.nombre = Convert.ToString(ds.Tables[0].Rows[0]["nombre"]);
                operador.apellidoPat = Convert.ToString(ds.Tables[0].Rows[0]["apellidoPat"]);
                operador.apellidoMAt = Convert.ToString(ds.Tables[0].Rows[0]["apellidoMat"]);
                operador.calle = Convert.ToString(ds.Tables[0].Rows[0]["calle"]);
                operador.numero = Convert.ToInt32(ds.Tables[0].Rows[0]["numero"]);
                operador.colonia = Convert.ToString(ds.Tables[0].Rows[0]["colonia"]);
                operador.municipio = Convert.ToString(ds.Tables[0].Rows[0]["municipio"]);
                operador.estado = Convert.ToString(ds.Tables[0].Rows[0]["estado"]);
                operador.cp = Convert.ToInt32(ds.Tables[0].Rows[0]["cp"]);
                operador.noCredencialElector = Convert.ToInt32(ds.Tables[0].Rows[0]["noCredencialElector"]);
                operador.fechaVigenciaLicencia = Convert.ToString(ds.Tables[0].Rows[0]["fechaVigenciaLicencia"]);
                operador.noLicencia = Convert.ToInt32(ds.Tables[0].Rows[0]["noLicencia"]);
                operador.padecimientos = Convert.ToString(ds.Tables[0].Rows[0]["padecimientos"]);
                operador.curp = Convert.ToString(ds.Tables[0].Rows[0]["curp"]);
                operador.noIMSS = Convert.ToInt32(ds.Tables[0].Rows[0]["noIMSS"]);
                operador.estatusConfiabilidad = Convert.ToString(ds.Tables[0].Rows[0]["estatusConfiabilidad"]);
                operador.motivoRechazo = Convert.ToString(ds.Tables[0].Rows[0]["motivoRechazo"]);
                operador.fechaRegistro = Convert.ToString(ds.Tables[0].Rows[0]["fechaRegistro"]);
                operador.puesto = Convert.ToString(ds.Tables[0].Rows[0]["puesto"]);
                operador.capacitadoChofer = Convert.ToChar(ds.Tables[0].Rows[0]["capacitadoChofer"]);
                operador.estatus = Convert.ToString(ds.Tables[0].Rows[0]["estatus"]);
                operador.motivo = Convert.ToString(ds.Tables[0].Rows[0]["motivo"]);
                operador.descripcion = Convert.ToString(ds.Tables[0].Rows[0]["descripcion"]);
                operador.fechaMotivo = Convert.ToString(ds.Tables[0].Rows[0]["fechaMotivo"]);
                operador.fotografia = Convert.ToString(ds.Tables[0].Rows[0]["fotografia"]);
                operador.placas = Convert.ToString(ds.Tables[0].Rows[0]["placas"]);
                operador.tipoUnidad = Convert.ToString(ds.Tables[0].Rows[0]["tipoUnidad"]);
            }

            return operador;
        }
        public static int OperadorDStoOperadorID(DataSet ds)
        {
            if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0]["idOperador"]);
            }

            return 0;
        }
    }
}
