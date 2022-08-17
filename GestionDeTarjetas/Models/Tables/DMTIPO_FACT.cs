using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class DMTIPO_FACT
    {
        public int FACT_ID { get; set; }
        public int FACT_PARM_ID { get; set; }
        public string FACT_TIPO_FACT { get; set; } = null!;
    }
}
