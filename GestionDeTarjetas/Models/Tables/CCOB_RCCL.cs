using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class CCOB_RCCL
    {
        public short RCCL_DIVISION_RCCL { get; set; }
        public int RCCL_SUCURSAL_IMP { get; set; }
        public string RCCL_TIPO_REC { get; set; } = null!;
        public decimal RCCL_NUMERO_RCCL { get; set; }
        public int RCCL_CLIENTE { get; set; }
        public DateTime RCCL_FECHA_EMI { get; set; }
        public string? RCCL_REF_CLIENTE { get; set; }
        public decimal RCCL_IMP_CTA_ORI { get; set; }
        public decimal RCCL_IMP_CTA_LOC { get; set; }
        public string RCCL_COBRADOR { get; set; } = null!;
        public DateTime? RCCL_FECHA_BAJA { get; set; }
        public short RCCL_ORIGEN_REC { get; set; }
        public int? RCCL_ENT_TARJ_CRE { get; set; }
        public short RCCL_DIAS_ATRASO { get; set; }
        public decimal RCCL_REQ_SOLIC_COB { get; set; }
        public decimal? RCCL_INC_MULTINODO { get; set; }
        public string? RCCL_NODO_ORIGEN { get; set; }
        public string? RCCL_TIPO_FC_CDO { get; set; }
        public decimal? RCCL_NRO_FC_CDO { get; set; }
        public string? RCCL_REF_SCOB_DEPU { get; set; }
        public short? RCCL_FCAL_DIAS_ATR { get; set; }
        public short? RCCL_DIASGR_ATR_RC { get; set; }
        public short? RCCL_TIENE_DTOS { get; set; }
        public decimal? RCCL_TOT_DTOS_ORI { get; set; }
        public decimal? RCCL_TOT_DTOS_LOC { get; set; }
        public string? RCCL_CUENTA_DTOS { get; set; }
        public int? RCCL_NC_DTOS { get; set; }
        public int? RCCL_ND_DTOS { get; set; }
        public DateTime? RCCL_ERM_FH_ENVIO { get; set; }
        public short? RCCL_APLICA_COTIZ_PROM_HIST { get; set; }
        public decimal? RCCL_COTIZACION_PROMEDIO { get; set; }

        public virtual CCOB_CLIE RCCL_CLIENTENavigation { get; set; } = null!;
        public virtual SIST_COBR RCCL_COBRADORNavigation { get; set; } = null!;
        public virtual CONT_CUEN? RCCL_CUENTA_DTOSNavigation { get; set; }
        public virtual CCOB_CTEC? RCCL_NC_DTOSNavigation { get; set; }
        public virtual CCOB_CTEC? RCCL_ND_DTOSNavigation { get; set; }
        public virtual CCOB_TCBV? RCCL_TIPO_FC_CDONavigation { get; set; }
        public virtual CCOB_TCBR RCCL_TIPO_RECNavigation { get; set; } = null!;
    }
}
