namespace GestionDeTarjetas.Models
{
    public class DatosExcel
    {
        public int DIVISION {get;set;}
        public int SUCURSAL {get;set;}
        public string TIPO  {get;set;}
        public int NUMERO   {get;set;}
        public int CLIENTE  {get;set;}
        public string NOMBRE_CLIENTE    {get;set;}
        public decimal MONEDA   {get;set;}
        public DateOnly FECHA_EMI   {get;set;}
        public decimal SALDO    {get;set;}
        public string NRO_TARJ  { get; set; }

    }
}
