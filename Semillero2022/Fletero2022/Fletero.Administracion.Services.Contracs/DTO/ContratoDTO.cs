using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.Contracs.DTO
{
    public class ContratoDTO
    {
        public int idContrato { get; set; }
        public string lugarFirmaContrato { get; set; } 
        public DateTime fechaFirmaContrato { get; set; }
        public string quienFirmaHomeDepot { get; set; }
        public string quienFirmaFletero { get; set; }
        public string quienRealizoFirma { get; set; }
        public DateTime fechaInicioContrato { get; set; }
        public DateTime fechaTerminacionContrato { get; set; }
        public Boolean renovacionAutomatica { get; set; }
        public int IDREGION { get; set; }
        public int IDDISTRICT { get; set; }
        public int IDSTORE { get; set; }
        public int idFletero { get; set; }
        public int statusContrato { get; set; }
        public int idCampoTarifa { get; set; }
        public int idArchivo { get; set; }
    }
}
