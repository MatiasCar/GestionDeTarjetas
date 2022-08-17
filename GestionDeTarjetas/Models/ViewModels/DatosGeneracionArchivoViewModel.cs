namespace GestionDeTarjetas.Models.ViewModels
{
    public class DatosGeneracionArchivoViewModel
    {

        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public DateTime Presentacion { get; set; }

        public DatosGeneracionArchivoViewModel() { }

        public DatosGeneracionArchivoViewModel(DateTime desde, DateTime hasta, DateTime presentacion) {
            Desde = desde;
            Hasta = hasta;
            Presentacion = presentacion;
        }
    }
}
