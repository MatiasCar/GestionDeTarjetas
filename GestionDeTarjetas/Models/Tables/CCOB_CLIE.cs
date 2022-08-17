using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class CCOB_CLIE
    {
        public CCOB_CLIE()
        {
            CCOB_CTECCTEC_CLIENTENavigation = new HashSet<CCOB_CTEC>();
            CCOB_CTECCTEC_CLIENTE_VENTANavigation = new HashSet<CCOB_CTEC>();
            CCOB_CVCL = new HashSet<CCOB_CVCL>();
            CCOB_RCCL = new HashSet<CCOB_RCCL>();
        }

        public int CLIE_CLIENTE { get; set; }
        public string CLIE_NOMBRE { get; set; } = null!;
        public string CLIE_NOMBRE_LEGAL { get; set; } = null!;
        public decimal CLIE_ES_CLI_GLOB { get; set; }
        public string? CLIE_DOMICILIO { get; set; }
        public string? CLIE_LOCALIDAD { get; set; }
        public string? CLIE_COD_POSTAL { get; set; }
        public string CLIE_PROVINCIA { get; set; } = null!;
        public string CLIE_PAIS { get; set; } = null!;
        public string? CLIE_TELEFONO { get; set; }
        public string? CLIE_FAX { get; set; }
        public string? CLIE_EMAIL { get; set; }
        public string? CLIE_OBSERVACION { get; set; }
        public string? CLIE_COD_PROVEEDOR { get; set; }
        public string? CLIE_REFERENCIA { get; set; }
        public string? CLIE_HORA_ATENCION { get; set; }
        public string? CLIE_HORA_ENTREGA { get; set; }
        public string CLIE_CONDICION_IVA { get; set; } = null!;
        public string? CLIE_CUIT { get; set; }
        public string? CLIE_ING_BRUTOS { get; set; }
        public string? CLIE_CONTAC_VENTA { get; set; }
        public string? CLIE_CONTAC_COBRO { get; set; }
        public string CLIE_COND_PAGO { get; set; } = null!;
        public string CLIE_MONEDA_CTE { get; set; } = null!;
        public string CLIE_CUENTA_CLIE { get; set; } = null!;
        public string CLIE_TIPO_CLI { get; set; } = null!;
        public string CLIE_ACTIVIDAD_CLI { get; set; } = null!;
        public string? CLIE_CLASIF_1 { get; set; }
        public string? CLIE_CLASIF_2 { get; set; }
        public string? CLIE_CLASIF_3 { get; set; }
        public string? CLIE_CLASIF_4 { get; set; }
        public string CLIE_VENDEDOR { get; set; } = null!;
        public string CLIE_ZONA_VENTA { get; set; } = null!;
        public string CLIE_COBRADOR { get; set; } = null!;
        public string CLIE_FLETE { get; set; } = null!;
        public decimal CLIE_BLOQUEADO_PED { get; set; }
        public decimal CLIE_BLOQUEADO_FAC { get; set; }
        public DateTime CLIE_FECHA_ALTA { get; set; }
        public DateTime? CLIE_FECHA_BAJA { get; set; }
        public decimal CLIE_HABIL_WEB { get; set; }
        public string? CLIE_PASSWORD_WEB { get; set; }
        public string? CLIE_FORMATO_FIMC { get; set; }
        public string? CLIE_VENDEDOR_2 { get; set; }
        public string? CLIE_STRING_1 { get; set; }
        public string? CLIE_STRING_2 { get; set; }
        public string? CLIE_STRING_3 { get; set; }
        public string? CLIE_STRING_4 { get; set; }
        public DateTime? CLIE_FECHA_1 { get; set; }
        public DateTime? CLIE_FECHA_2 { get; set; }
        public DateTime? CLIE_FECHA_3 { get; set; }
        public DateTime? CLIE_FECHA_4 { get; set; }
        public string? CLIE_CLASIF_NPCV_1 { get; set; }
        public string? CLIE_CLASIF_NPCV_2 { get; set; }
        public string? CLIE_CLASIF_NPCV_3 { get; set; }
        public string? CLIE_CLASIF_NPCV_4 { get; set; }
        public string? CLIE_CLASIF_NPCV_5 { get; set; }
        public string? CLIE_CLASIF_NPCV_6 { get; set; }
        public decimal CLIE_HABIL_CC_CLIE { get; set; }
        public string? CLIE_CLIENTE_EXT { get; set; }
        public DateTime? CLIE_FECHA_PROX_GC { get; set; }
        public string? CLIE_PROX_GES_COBR { get; set; }
        public short CLIE_ACCT_GENCBPTE { get; set; }
        public string? CLIE_NODO_ORIGEN { get; set; }
        public string? CLIE_MUNICIPIO { get; set; }
        public decimal CLIE_INF_TABASTO { get; set; }
        public decimal CLIE_COBRO_CORREL { get; set; }
        public string? CLIE_VEHICULO { get; set; }
        public string? CLIE_DISTRIBUIDOR { get; set; }
        public string? CLIE_ZONA_DISTRIB { get; set; }
        public string? CLIE_CALLE { get; set; }
        public int? CLIE_NRO_CALLE { get; set; }
        public string? CLIE_PISO { get; set; }
        public string? CLIE_DEPTO { get; set; }
        public string? CLIE_BARRIO { get; set; }
        public short CLIE_DIASGR_ATR_RC { get; set; }
        public string? CLIE_CLASIF_5 { get; set; }
        public string? CLIE_CLASIF_6 { get; set; }
        public string? CLIE_CLASIF_7 { get; set; }
        public string? CLIE_CLASIF_8 { get; set; }
        public string? CLIE_CLASIF_9 { get; set; }
        public string? CLIE_SITIO_WEB { get; set; }
        public string? CLIE_DESCRIP_ACTIV { get; set; }
        public int? CLIE_FACT_ANUAL { get; set; }
        public int? CLIE_CANT_EMPLEAD { get; set; }
        public string? CLIE_ECM_EMAIL { get; set; }
        public string? CLIE_ECM_ASUNTO { get; set; }
        public string? CLIE_ECM_CUERPO { get; set; }
        public string? CLIE_OBSERVACION_PROX_GES_COBR { get; set; }
        public string? CLIE_COD_CALLE { get; set; }
        public string? CLIE_ERM_EMAIL { get; set; }
        public string? CLIE_ERM_ASUNTO { get; set; }
        public string? CLIE_ERM_CUERPO { get; set; }
        public decimal? CLIE_TASA_MENS_INTERES { get; set; }
        public DateTime? CLIE_HORA_PROX_GC { get; set; }
        public short? CLIE_NIVEL_ACCESO_WEB { get; set; }
        public byte CLIE_BLOQUEADO_RESERVAS { get; set; }
        public string? CLIE_LOGOTIPO_NOM_ORI { get; set; }
        public string? CLIE_LOGOTIPO_NOM_ALMAC { get; set; }
        public byte CLIE_RECEPTOR_FACT_CRED_ELEC { get; set; }
        public decimal? CLIE_FACT_CRED_ELEC_MONTO_MIN_LOCAL { get; set; }
        public byte? CLIE_BLOQUEADO_CONTRATOS { get; set; }
        public short? CLIE_TIPO_CONTRIBUYENTE_IIBB { get; set; }
        public string? CLIE_FACT_CRED_ELEC_CIRCUITO_DE_PAGO { get; set; }

        public virtual SIST_COBR CLIE_COBRADORNavigation { get; set; } = null!;
        public virtual CONT_CUEN CLIE_CUENTA_CLIENavigation { get; set; } = null!;
        public virtual CCOB_CLPF CCOB_CLPF { get; set; } = null!;
        public virtual ICollection<CCOB_CTEC> CCOB_CTECCTEC_CLIENTENavigation { get; set; }
        public virtual ICollection<CCOB_CTEC> CCOB_CTECCTEC_CLIENTE_VENTANavigation { get; set; }
        public virtual ICollection<CCOB_CVCL> CCOB_CVCL { get; set; }
        public virtual ICollection<CCOB_RCCL> CCOB_RCCL { get; set; }
    }
}
