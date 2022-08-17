using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class CCOB_CVCC
    {
        public int CVCC_CTACTE_CTEC { get; set; }
        public short CVCC_DIVISION_CVCL { get; set; }
        public int CVCC_SUCURSAL_CVCL { get; set; }
        public string CVCC_TIPO_CVCL { get; set; } = null!;
        public decimal CVCC_NUMERO_CVCL { get; set; }

        public virtual CCOB_CVCL CVCC_ { get; set; } = null!;
        public virtual CCOB_CTEC CVCC_CTACTE_CTECNavigation { get; set; } = null!;
    }
}
