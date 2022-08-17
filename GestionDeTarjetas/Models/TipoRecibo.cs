namespace GestionDeTarjetas.Models
{
    public class TipoRecibo
    {
        
        public string TipoDeRecibo { get; set; }

        public TipoRecibo( string tipoRecibo)
        {
            
            TipoDeRecibo = tipoRecibo;
        }
    }
}
