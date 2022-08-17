namespace GestionDeTarjetas.Models
{
    public class Parametro
    {
        public int Id { get; set; }
        public string NombreTarjeta { get; set; }

        public Parametro(int id, string nombreTarjeta)
        {
            Id = id;
            NombreTarjeta = nombreTarjeta;
        }
    }
}
