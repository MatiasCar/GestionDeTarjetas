using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class DMED_TARJ
    {
        public string TARJ_TIPO_COMP { get; set; } = null!;
        public byte TARJ_TIPO_TARJETA { get; set; }
        public string? TARJ_CUENTA { get; set; }

        public virtual CONT_CUEN? TARJ_CUENTANavigation { get; set; }
        public virtual CCOB_TCCB TARJ_TIPO_COMPNavigation { get; set; } = null!;
    }
}
