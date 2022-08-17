using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class dmLOTE_COMPROBANTES
    {
        public int LOTE_NUMINT { get; set; }
        public short LOTE_DIVISION { get; set; }
        public int LOTE_SUCURSAL { get; set; }
        public string LOTE_TIPO { get; set; } = null!;
        public decimal LOTE_NUMERO { get; set; }
        public short LOTE_RENGLON { get; set; }
        public int LOTE_CLIENTE { get; set; }
        public string LOTE_MONEDA { get; set; } = null!;
        public decimal LOTE_COTIZACION { get; set; }
        public short LOTE_NUM_CUOTA { get; set; }
        public int? LOTE_TIPO_TARJETA { get; set; }
        public DateTime LOTE_FECHA_EMI { get; set; }
        public DateTime LOTE_VTO { get; set; }
        public decimal LOTE_SALDO_ORI { get; set; }
        public decimal LOTE_SALDO_LOC { get; set; }
        public string LOTE_NRO_TARJ { get; set; } = null!;
        public short LOTE_TIPO_REG { get; set; }
        public decimal LOTE_IMP_TOT_LOC { get; set; }
        public string LOTE_NOMBRE_CLIENTE { get; set; } = null!;
        public string LOTE_CLASIF_NPCV { get; set; } = null!;
        public string LOTE_SIGNO { get; set; } = null!;
        public decimal LOTE_IMPORTE_TOTAL { get; set; }
        public decimal LOTE_TOTAL_SALDO_ORI { get; set; }
        public decimal LOTE_TOTAL_SALDO_LOC { get; set; }
        public decimal LOTE_MAX_CVCL { get; set; }
        public int LOTE_CUOTAS_TOTAL { get; set; }
    }
}
