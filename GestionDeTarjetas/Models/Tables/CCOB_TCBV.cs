using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class CCOB_TCBV
    {
        public CCOB_TCBV()
        {
            CCOB_CVCL = new HashSet<CCOB_CVCL>();
            CCOB_RCCL = new HashSet<CCOB_RCCL>();
        }

        public string TCBV_TIPO_VAR { get; set; } = null!;
        public string TCBV_SIGNO { get; set; } = null!;
        public string TCBV_ES_FCNDNC { get; set; } = null!;
        public string TCBV_SUBDIARIO { get; set; } = null!;
        public string TCBV_LETRA { get; set; } = null!;
        public decimal TCBV_ES_DIF_CAMBIO { get; set; }
        public decimal TCBV_CON_IMPUESTOS { get; set; }
        public decimal TCBV_LIBRO_VENTAS { get; set; }
        public decimal TCBV_LIBRO_COMPRAS { get; set; }
        public decimal TCBV_ES_VENTA { get; set; }
        public short TCBV_LONG_DESC_REN { get; set; }
        public short? TCBV_TIPO_TCPE { get; set; }
        public decimal TCBV_COMISIONABLE { get; set; }
        public decimal TCBV_RESVTA_RANGO { get; set; }
        public short TCBV_ING_CPBTE_REF { get; set; }
        public short? TCBV_TIPO_TCAF { get; set; }
        public decimal TCBV_ALM_ELEC_DUPL { get; set; }
        public decimal TCBV_ES_PTO_VENTA { get; set; }
        public string? TCBV_CLASIF_NPCV_1 { get; set; }
        public string? TCBV_CLASIF_NPCV_2 { get; set; }
        public string? TCBV_CLASIF_NPCV_3 { get; set; }
        public string? TCBV_CLASIF_NPCV_4 { get; set; }
        public string? TCBV_CLASIF_NPCV_5 { get; set; }
        public string? TCBV_CLASIF_NPCV_6 { get; set; }
        public decimal TCBV_COBRO_CORREL { get; set; }
        public decimal TCBV_COMPENSABLE { get; set; }
        public short? TCBV_PRIORIDAD_CMP { get; set; }
        public short? TCBV_ESTADO_VT_CMP { get; set; }
        public short? TCBV_NROINF_IVACOM { get; set; }
        public short TCBV_ES_CPBTE_ELECTRONICO { get; set; }
        public short? TCBV_CLASE_CPBTE_ACER { get; set; }
        public short? TCBV_CLASE_FONC { get; set; }
        public short? TCBV_LIQ_ACOPIO_PARC_FIN { get; set; }
        public short TCBV_CTROL_NRO_REF_EXTERNA { get; set; }
        public short TCBV_CTROL_NRO_REF_EXT_ACCION { get; set; }
        public short? TCBV_CLASE_CPBTE_VTA_ACOPIO { get; set; }
        public short? TCBV_COE_MODO_AUTORIZACION { get; set; }
        public string? TCBV_CAMPO_OPCIONAL_FE { get; set; }
        public byte TCBV_ES_MOV_CHEQUE_RECHAZADO { get; set; }
        public byte TCBV_TC_HABIL_ING_RECARGO_FINANCIERO { get; set; }
        public byte TCBV_TC_APLICA_DESC_RECARGO_FINANCIERO { get; set; }
        public byte TCBV_HABIL_AUTORIZ_FACTELE_PDVE { get; set; }
        public byte TCBV_ES_CREDITO_ELECTRONICO { get; set; }
        public short? TCBV_TIPO_COMP_SIRE { get; set; }

        public virtual CCOB_TCCB TCBV_TIPO_VARNavigation { get; set; } = null!;
        public virtual ICollection<CCOB_CVCL> CCOB_CVCL { get; set; }
        public virtual ICollection<CCOB_RCCL> CCOB_RCCL { get; set; }
    }
}
