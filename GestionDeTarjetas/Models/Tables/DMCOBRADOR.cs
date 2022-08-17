using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class DMCOBRADOR
    {
        public int COBR_ID { get; set; }
        public int COBR_PARM_ID { get; set; }
        public string COBR_COBRADOR { get; set; } = null!;
    }
}
