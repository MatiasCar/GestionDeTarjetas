using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class DMPARM_CONF
    {
        public int PARM_ID { get; set; }
        public string PARM_NOMBRE { get; set; } = null!;
        public short PARM_UTILIZABLE { get; set; }
    }
}
