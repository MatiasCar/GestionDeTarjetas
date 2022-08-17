using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class CCOB_CTEC
    {
        public CCOB_CTEC()
        {
            CCOB_RCCLRCCL_NC_DTOSNavigation = new HashSet<CCOB_RCCL>();
            CCOB_RCCLRCCL_ND_DTOSNavigation = new HashSet<CCOB_RCCL>();
            CCOB_VCTC = new HashSet<CCOB_VCTC>();
        }

        public int CTEC_CTACTE_CTEC { get; set; }
        public string CTEC_ORIGEN { get; set; } = null!;
        public short CTEC_DIVISION { get; set; }
        public int CTEC_SUCURSAL_IMP { get; set; }
        public int CTEC_SUCURSAL_EMP { get; set; }
        public int CTEC_CLIENTE { get; set; }
        public int? CTEC_CLIENTE_VENTA { get; set; }
        public DateTime CTEC_FECHA_EMI { get; set; }
        public string CTEC_CONDICION_IVA { get; set; } = null!;
        public decimal CTEC_DISCRIMIN_IMP { get; set; }
        public string? CTEC_LETRA { get; set; }
        public string CTEC_COND_PAGO { get; set; } = null!;
        public string CTEC_SIGNO { get; set; } = null!;
        public decimal CTEC_ES_DIF_CAMBIO { get; set; }
        public string? CTEC_DESCRIPCION { get; set; }
        public string CTEC_MONEDA { get; set; } = null!;
        public decimal CTEC_COTIZACION { get; set; }
        public decimal CTEC_IMP_BRU_ORI { get; set; }
        public decimal CTEC_IMP_BRU_LOC { get; set; }
        public decimal CTEC_IMP_TOT_ORI { get; set; }
        public decimal CTEC_IMP_TOT_LOC { get; set; }
        public DateTime CTEC_FECHA_PROX_GC { get; set; }
        public string? CTEC_ORIGEN_CVCL { get; set; }
        public string? CTEC_GESTION_COBR { get; set; }
        public short? CTEC_EST_CC_CTACTE { get; set; }
        public DateTime? CTEC_FEC_CC_CTACTE { get; set; }
        public decimal? CTEC_IMP_CC_CTACTE { get; set; }
        public string? CTEC_OBS_CC_CTACTE { get; set; }
        public DateTime? CTEC_HORA_PROX_GC { get; set; }

        public virtual CCOB_CLIE CTEC_CLIENTENavigation { get; set; } = null!;
        public virtual CCOB_CLIE? CTEC_CLIENTE_VENTANavigation { get; set; }
        public virtual CCOB_CVCC CCOB_CVCC { get; set; } = null!;
        public virtual ICollection<CCOB_RCCL> CCOB_RCCLRCCL_NC_DTOSNavigation { get; set; }
        public virtual ICollection<CCOB_RCCL> CCOB_RCCLRCCL_ND_DTOSNavigation { get; set; }
        public virtual ICollection<CCOB_VCTC> CCOB_VCTC { get; set; }
    }
}
