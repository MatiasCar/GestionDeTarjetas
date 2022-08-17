using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class CONT_CUEN
    {
        public CONT_CUEN()
        {
            CCOB_CLIE = new HashSet<CCOB_CLIE>();
            CCOB_RCCL = new HashSet<CCOB_RCCL>();
            CCOB_TCBRTCBR_CTADEB_REDRCNavigation = new HashSet<CCOB_TCBR>();
            CCOB_TCBRTCBR_CTAHAB_REDRCNavigation = new HashSet<CCOB_TCBR>();
            DMED_TARJ = new HashSet<DMED_TARJ>();
        }

        public string CUEN_CUENTA { get; set; } = null!;
        public string CUEN_NOMBRE { get; set; } = null!;
        public string CUEN_MONEDA { get; set; } = null!;
        public decimal CUEN_IMPUTABLE { get; set; }
        public decimal CUEN_AJU_INF { get; set; }
        public decimal CUEN_AJU_CON { get; set; }
        public decimal CUEN_DISTRIBUCION { get; set; }
        public decimal CUEN_IMP_CONTAB { get; set; }
        public decimal CUEN_IMP_CPAGAR { get; set; }
        public decimal CUEN_IMP_CCOBRAR { get; set; }
        public decimal CUEN_IMP_TESOR { get; set; }
        public decimal CUEN_IMP_VENTAS { get; set; }
        public decimal CUEN_IMP_STOCK { get; set; }
        public decimal CUEN_IMP_COMPRAS { get; set; }
        public decimal CUEN_IMP_ACTIVO { get; set; }
        public decimal CUEN_IMP_SUELDOS { get; set; }
        public string? CUEN_UNIMED { get; set; }
        public string? CUEN_SIGNO_SAL { get; set; }
        public string? CUEN_MAESTRO { get; set; }
        public decimal? CUEN_USA_REFER { get; set; }
        public decimal CUEN_UTILIZABLE { get; set; }
        public decimal CUEN_IMP_AUTO { get; set; }
        public decimal CUEN_ES_CARGO_DIF { get; set; }
        public decimal CUEN_IMP_PRODUC { get; set; }
        public decimal CUEN_ES_OP_ESPECIE { get; set; }
        public decimal CUEN_ES_MONETARIA { get; set; }
        public decimal CUEN_IMP_GS_CONTR { get; set; }
        public short CUEN_IMP_ACER { get; set; }
        public byte CUEN_HABIL_REST_IMP_USU { get; set; }
        public byte CUEN_DEFAULT_REST_IMP_USU { get; set; }
        public byte CUEN_HABIL_REST_VIS_USU { get; set; }
        public byte CUEN_DEFAULT_HABIL_REST_VIS_USU { get; set; }
        public DateTime? CUEN_FECHA_TOPE_IMPUTACION { get; set; }
        public string? CUEN_CLASE_IMPUTABLE { get; set; }
        public byte CUEN_SE_UTILIZA_COBR_IDENTIFICAR { get; set; }
        public byte? CUEN_VALIDA_EXIS_REFERENCIA { get; set; }
        public byte CUEN_GENERA_RESULTADO_TENENCIA { get; set; }
        public string? CUEN_CUENTA_PADRE { get; set; }

        public virtual ICollection<CCOB_CLIE> CCOB_CLIE { get; set; }
        public virtual ICollection<CCOB_RCCL> CCOB_RCCL { get; set; }
        public virtual ICollection<CCOB_TCBR> CCOB_TCBRTCBR_CTADEB_REDRCNavigation { get; set; }
        public virtual ICollection<CCOB_TCBR> CCOB_TCBRTCBR_CTAHAB_REDRCNavigation { get; set; }
        public virtual ICollection<DMED_TARJ> DMED_TARJ { get; set; }
    }
}
