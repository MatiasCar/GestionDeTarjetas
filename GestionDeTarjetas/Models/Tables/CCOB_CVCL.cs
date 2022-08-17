using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class CCOB_CVCL
    {
        public short CVCL_DIVISION_CVCL { get; set; }
        public int CVCL_SUCURSAL_IMP { get; set; }
        public string CVCL_TIPO_VAR { get; set; } = null!;
        public decimal CVCL_NUMERO_CVCL { get; set; }
        public int CVCL_CLIENTE { get; set; }
        public DateTime CVCL_FECHA_EMI { get; set; }
        public DateTime? CVCL_FECHA_BAJA { get; set; }
        public string CVCL_ORIGEN { get; set; } = null!;
        public string? CVCL_REFERENCIA_1 { get; set; }
        public string? CVCL_REFERENCIA_2 { get; set; }
        public DateTime? CVCL_FECHA_IMPRESO { get; set; }
        public string? CVCL_CLASIF_NPCV_1 { get; set; }
        public string? CVCL_CLASIF_NPCV_2 { get; set; }
        public string? CVCL_CLASIF_NPCV_3 { get; set; }
        public string? CVCL_CLASIF_NPCV_4 { get; set; }
        public string? CVCL_CLASIF_NPCV_5 { get; set; }
        public string? CVCL_CLASIF_NPCV_6 { get; set; }
        public decimal CVCL_IMP_FISCAL { get; set; }
        public string? CVCL_NUMERO_CAI { get; set; }
        public DateTime? CVCL_FECHA_VTO_CAI { get; set; }
        public string? CVCL_OPER_NGV_AFIP { get; set; }
        public decimal CVCL_CALCGR_IMP_IT { get; set; }
        public string? CVCL_NUMERADOR { get; set; }
        public decimal? CVCL_INC_MULTINODO { get; set; }
        public string? CVCL_NODO_ORIGEN { get; set; }
        public decimal? CVCL_ES_ND_INTERES { get; set; }
        public short? CVCL_TIPO_CALC_INT { get; set; }
        public decimal? CVCL_TASA_INT_MES { get; set; }
        public DateTime? CVCL_NUFEC_VTO_INT { get; set; }
        public DateTime? CVCL_NUFEC_VTO_FIN { get; set; }
        public string? CVCL_REF_PREF_DEPU { get; set; }
        public DateTime? CVCL_FEC_ENT_VAL { get; set; }
        public DateTime? CVCL_ECM_FH_ENVIO { get; set; }
        public short? CVCL_ES_CPBTE_ELECTRONICO { get; set; }
        public string? CVCL_ESTADO_CPBTE_ELEC { get; set; }
        public short? CVCL_ES_PREST_SERVICIOS { get; set; }
        public DateTime? CVCL_FECHA_DES_PREST_SERVICIOS { get; set; }
        public DateTime? CVCL_FECHA_HAS_PREST_SERVICIOS { get; set; }
        public string? CVCL_OBS_AUT_CPBTE_ELEC { get; set; }
        public int? CVCL_NRO_LOTE_AUT_CPBTE_ELEC_WS { get; set; }
        public short? CVCL_CLASE_CPBTE_ACER { get; set; }
        public short? CVCL_CLASE_FONC { get; set; }
        public short? CVCL_LIQ_ACOPIO_PARC_FIN { get; set; }
        public string? CVCL_FEC_PROCESO_CAE { get; set; }
        public short? CVCL_CLASE_CPBTE_VTA_ACOPIO { get; set; }
        public int? CVCL_NUMINT_PACA { get; set; }
        public short? CVCL_COE_MODO_AUTORIZACION { get; set; }
        public decimal? CVCL_COE { get; set; }
        public short? CVCL_COE_ESTADO { get; set; }
        public DateTime? CVCL_COE_FECHA_ANULACION { get; set; }
        public DateTime? CVCL_COE_FECHA_AUTORIZACION { get; set; }
        public string? CVCL_CAMPO_OPCIONAL_FE { get; set; }
        public byte? CVCL_ES_MOV_CHEQUE_RECHAZADO { get; set; }
        public string? CVCL_REFERENCIA_3 { get; set; }
        public byte? CVCL_COMPROBANTE_CRED_ELECT { get; set; }
        public decimal? CVCL_FACT_CRED_ELEC_MONTO_MIN_LOC { get; set; }
        public byte? CVCL_FACT_CRED_ELEC_ANUL_COMPR_RECH { get; set; }
        public string? CVCL_FACT_CRED_ELEC_CIRCUITO_DE_PAGO { get; set; }
        public DateTime? CVCL_FECHA_ASOCIADA_DESDE { get; set; }
        public DateTime? CVCL_FECHA_ASOCIADA_HASTA { get; set; }

        public virtual CCOB_CLIE CVCL_CLIENTENavigation { get; set; } = null!;
        public virtual CCOB_TCBV CVCL_TIPO_VARNavigation { get; set; } = null!;
        public virtual CCOB_CVCC CCOB_CVCC { get; set; } = null!;
    }
}
