using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fletero2022.Areas.Administracion.Models
{
    public class OperadorModel
    {

        public OperadorModel()
        {

        }
        public int idOperador { get; set; }
        public int distrito { get; set; }
        public int fletero { get; set; }
        public int unidad { get; set; }
        public String nombre { get; set; }
        public String apellidoPat { get; set; }
        public String apellidoMAt { get; set; }
        public String calle { get; set; }
        public int numero { get; set; }
        public String colonia { get; set; }
        public String municipio { get; set; }
        public String estado { get; set; }
        public int cp { get; set; }
        public int noCredencialElector { get; set; }
        public String fechaVigenciaLicencia { get; set; }
        public int noLicencia { get; set; }
        public String padecimientos { get; set; }
        public String curp { get; set; }
        public int noIMSS { get; set; }
        public String estatusConfiabilidad { get; set; }
        public String motivoRechazo { get; set; }
        public String fechaRegistro { get; set; }
        public String puesto { get; set; }
        public char capacitadoChofer { get; set; }
        public String estatus { get; set; }
        public String motivo { get; set; }
        public String descripcion { get; set; }
        public String fechaMotivo { get; set; }
        public String fotografia { get; set; }
        public String placas { get; set; }
        public String tipoUnidad { get; set; }
    }
}