namespace GestionDeTarjetas.Models.ViewModels
{
    public class ConfigViewModel
    {
        //public int IdTarjeta { get; set; }
        public List<string> TipoFact { get; set; }

        public List<string> TipoRec { get; set; }

        public List<string> CtaContable { get; set; }

        public List<string> Cobrador { get; set; }

        public bool Utilizable { get; set; }

        public ConfigViewModel() { }
        public ConfigViewModel( List<string> tipoFact, List<string> tipoRec, List<string> ctaContable, List<string> cobrador, bool utilizable)
        {
            //IdTarjeta = idTarjeta;
            TipoFact = tipoFact;
            TipoRec = tipoRec;
            CtaContable = ctaContable;
            Cobrador = cobrador;
            Utilizable = utilizable;
        }
    }
}
