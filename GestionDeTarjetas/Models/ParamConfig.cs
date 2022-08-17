using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDeTarjetas.Models
{
    public class ParamConfig
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength]
        [Display(Name = "PARM_TIPO_FACTURA")]
        public string TipoFactura { get; set; }

        [Required]
        [StringLength(3)]
        [Display(Name = "PARM_TIPO_RECIBO")]
        public string TipoRecibo { get; set; }

        [Required]
        [Column(TypeName = "smallint")]
        [Display(Name = "PARM_UTILIZABLE")]
        public int Utilizable { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength]
        [Display(Name = "PARM_CUENTA_RECIBOS")]
        public string CuentaRecibos { get; set; }


        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength]
        [Display(Name = "PARM_COBRADOR")]
        public string Cobrador { get; set; }
        //public ParamConfig(string tipoFactura, string tipoRecibo, int utilizable)
        //{
        //    TipoFactura = tipoFactura;
        //    TipoRecibo = tipoRecibo;
        //    Utilizable = utilizable;
        //}

    }
}
