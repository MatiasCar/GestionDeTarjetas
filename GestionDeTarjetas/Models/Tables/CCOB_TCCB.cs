using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class CCOB_TCCB
    {
        public CCOB_TCCB()
        {
            DMED_TARJ = new HashSet<DMED_TARJ>();
        }

        public string TCCB_TIPO_COM { get; set; } = null!;
        public string TCCB_NOMBRE { get; set; } = null!;
        public string TCCB_CLASE { get; set; } = null!;
        public decimal TCCB_UTILIZABLE { get; set; }
        public decimal TCCB_CONTROL_SFEC { get; set; }
        public string TCCB_NOMBRE_IMP { get; set; } = null!;
        public byte TCCB_GENERA_CBTE_ARCHIVO_ADJ { get; set; }

        public virtual CCOB_TCBR CCOB_TCBR { get; set; } = null!;
        public virtual CCOB_TCBV CCOB_TCBV { get; set; } = null!;
        public virtual ICollection<DMED_TARJ> DMED_TARJ { get; set; }
    }
}
