using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fletero2022.Areas.Administracion.Models
{
    public class UnidadModel
    {
        public UnidadModel() 
        {
        
        }
        
        public int IdUnidad { get; set; }
        public int Fletero { get; set; }
        public int Permiso { get; set; }
        public int TipoUnidad { get; set; }
        public string Numero_eco { get; set; }
        public int TipoCarroceria { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Largo { get; set; }
        public string Ancho { get; set; }
        public string Alto { get; set; }
        public int Peso { get; set; }
        public int PolizaSeguro { get; set; }
        public int Placas { get; set; }
        public string Caract_especial { get; set; }
        public bool GPS { get; set; }

        public List<DistritoDTO> Districts { get; set; }
        public List<TiendaDTO> Stores { get; set; }
        public List<FleteroDTO> TodosFleteros { get; set; }
    }
}