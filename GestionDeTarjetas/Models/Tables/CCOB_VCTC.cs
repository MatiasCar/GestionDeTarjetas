using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class CCOB_VCTC
    {
        public int VCTC_CTACTE_CTEC { get; set; }
        public short VCTC_RENGLON_VCTC { get; set; }
        public DateTime VCTC_FECHA_VTO { get; set; }
        public DateTime VCTC_FECHA_VTO_FIN { get; set; }
        public short VCTC_NUM_CUOTA { get; set; }
        public decimal VCTC_IMP_ORI { get; set; }
        public decimal VCTC_IMP_LOC { get; set; }
        public decimal VCTC_SAL_ORI { get; set; }
        public decimal VCTC_SAL_LOC { get; set; }
        public DateTime? VCTC_FECHA_VTO_INT { get; set; }

        public virtual CCOB_CTEC VCTC_CTACTE_CTECNavigation { get; set; } = null!;
    }
}
