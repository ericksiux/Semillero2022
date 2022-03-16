using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fletero.Administracion.Services.Contracs.DTO
{
    public class CamposTarifas
    {
        public int idCampoTarifa { get; set; }

        public Boolean metodoPagoLocal { get; set; }

        public decimal tarifaRentaDiaria { get; set; }

        public int distanciaZonaLocal { get; set; }

        public int horasLaboral { get; set; }

        public decimal tarifaHoraExtra { get; set; }

        public decimal tarifaEntregaLocal { get; set; }

        public decimal tarifaVueltaLocal { get; set; }

        public decimal tarifaReparto { get; set; }

        public Boolean incluyeManiobra { get; set; }

        public int unidadCarga { get; set; }
    }
}
