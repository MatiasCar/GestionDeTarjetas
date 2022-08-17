using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class DMCTA_CONT
    {
        public int CONT_ID { get; set; }
        public int CONT_PARM_ID { get; set; }
        public string CONT_CTA { get; set; } = null!;
    }
}
