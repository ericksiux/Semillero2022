namespace Fletero.Administracion.Integration.DAO.Mapper
{
    public class CamposTarifasDTO
    {
        internal bool metodoPagoLocal;
        internal decimal tarifaRentaDiaria;
        internal int distanciaZonaLocal;
        internal int horasLaboral;
        internal decimal tarifaHoraExtra;
        internal decimal tarifaEntregaLocal;
        internal decimal tarifaVueltaLocal;
        internal decimal tarifaReparto;
        internal bool incluyeManiobra;
        internal int unidadCarga;

        public int idCampoTarifa { get; internal set; }
    }
}