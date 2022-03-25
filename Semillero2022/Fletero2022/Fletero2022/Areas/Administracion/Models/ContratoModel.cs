using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fletero2022.Areas.Administracion.Models
{
    public class ContratoModel
    {
        public ContratoModel()
        {
        }
        public List<TiendaDTO> Stores { get; set; }
        public List<DistritoDTO> Districts { get; set; }
        public List<FleteroDTO> TodosFleteros { get; set; }
        public List<TituloMotivoDTO> TituloMotivo { get; set; }
        public int IdContrato { get; set; }
        public string lugarFirmaContrato { get; set; }
        public DateTime fechaFirmaContrato { get; set; }
        public string quienFirmaHomeDepot { get; set; }
        public string quienFirmaFletero { get; set; }
        public string quienRealizoFirma { get; set; }
        public DateTime fechaInicioContrato { get; set; }
        public DateTime fechaTerminacionContrato { get; set; }
        public Boolean renovacionAutomatica { get; set; }
        public int IDREGION { get; set; }
        public int statusContrato { get; set; }
        public int idCampoTarifa { get; set; }
        public int idArchivo { get; set; }
    }
}