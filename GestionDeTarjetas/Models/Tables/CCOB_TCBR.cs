using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class CCOB_TCBR
    {
        public CCOB_TCBR()
        {
            CCOB_RCCL = new HashSet<CCOB_RCCL>();
        }

        public string TCBR_TIPO_REC { get; set; } = null!;
        public string TCBR_SUBDIARIO { get; set; } = null!;
        public short TCBR_CLASE_RECIBO { get; set; }
        public decimal TCBR_USA_TALONARIO { get; set; }
        public decimal TCBR_LIBRO_VENTAS { get; set; }
        public decimal TCBR_LIBRO_COMPRAS { get; set; }
        public decimal? TCBR_ES_ACRED_TARJ { get; set; }
        public decimal TCBR_COMISIONABLE { get; set; }
        public short? TCBR_TIPO_TCAF { get; set; }
        public decimal TCBR_REQ_SOLIC_COB { get; set; }
        public decimal TCBR_AJU_DIF_REDRC { get; set; }
        public string? TCBR_CTADEB_REDRC { get; set; }
        public string? TCBR_CTAHAB_REDRC { get; set; }
        public decimal? TCBR_REDMAX_REDRC { get; set; }
        public string TCBR_FORMAT_REF { get; set; } = null!;
        public decimal TCBR_CONTROL_NRCL { get; set; }
        public short TCBR_FCAL_DIAS_ATR { get; set; }
        public decimal TCBR_REF_OBLIG { get; set; }
        public decimal TCBR_DESCRIP_OBLIG { get; set; }
        public short TCBR_PERMITE_ING_DTOS { get; set; }
        public short TCBR_CANT_MAX_DTOS { get; set; }
        public short? TCBR_TIPO_DTO { get; set; }
        public short TCBR_CTRL_NRCL_ACCION { get; set; }
        public byte TCBR_RENDICION_CAJA { get; set; }

        public virtual CONT_CUEN? TCBR_CTADEB_REDRCNavigation { get; set; }
        public virtual CONT_CUEN? TCBR_CTAHAB_REDRCNavigation { get; set; }
        public virtual CCOB_TCCB TCBR_TIPO_RECNavigation { get; set; } = null!;
        public virtual ICollection<CCOB_RCCL> CCOB_RCCL { get; set; }
    }
}
