using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class DMTIPO_RECI
    {
        public int RECI_ID { get; set; }
        public int RECI_PARM_ID { get; set; }
        public string RECI_TIPO_RECI { get; set; } = null!;
    }
}
