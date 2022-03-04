using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.Contracs.DTO
{
    public class UnidadCargaDTO
    {
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

    }
}
