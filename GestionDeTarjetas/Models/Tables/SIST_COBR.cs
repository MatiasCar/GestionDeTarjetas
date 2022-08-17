using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class SIST_COBR
    {
        public SIST_COBR()
        {
            CCOB_CLIE = new HashSet<CCOB_CLIE>();
            CCOB_RCCL = new HashSet<CCOB_RCCL>();
        }

        public string COBR_COBRADOR { get; set; } = null!;
        public string COBR_NOMBRE { get; set; } = null!;
        public decimal COBR_UTILIZABLE { get; set; }
        public decimal COBR_PORC_COMISION { get; set; }

        public virtual ICollection<CCOB_CLIE> CCOB_CLIE { get; set; }
        public virtual ICollection<CCOB_RCCL> CCOB_RCCL { get; set; }
    }
}
