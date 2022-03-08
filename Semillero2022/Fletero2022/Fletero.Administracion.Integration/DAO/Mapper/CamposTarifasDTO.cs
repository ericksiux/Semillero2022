namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public class CamposTarifasDTO
    {
        public int idCampoTarifa { get; internal set; }
        public string metodoPagoLocal { get; internal set; }
        public decimal tarifaRentaDiaria { get; internal set; }
        public int distanciaZonaLocal { get; internal set; }
        public int horasLaboral { get; internal set; }
        public decimal tarifaHoraExtra { get; internal set; }
        public decimal tarifaEntregaLocal { get; internal set; }
        public decimal tarifaVueltaLocal { get; internal set; }
        public decimal tarifaReparto { get; internal set; }
        public bool incluyeManiobra { get; internal set; }
        public int unidadCarga { get; internal set; }
    }
}