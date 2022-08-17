using System;
using System.Collections.Generic;

namespace GestionDeTarjetas.Models
{
    public partial class CCOB_CLPF
    {
        public int CLPF_CLIENTE { get; set; }
        public DateTime? CLPF_FECHA_NACIM { get; set; }
        public string? CLPF_PAIS_NACIM { get; set; }
        public string? CLPF_NACIONALIDAD { get; set; }
        public string? CLPF_SEXO { get; set; }
        public string? CLPF_PROFESION { get; set; }
        public int? CLPF_ENT_TARJ_CRE { get; set; }
        public DateTime? CLPF_FVTO_TARJ_CRE { get; set; }
        public string? CLPF_TIPO_DOC { get; set; }
        public int? CLPF_NUMERO_DOC { get; set; }
        public string? CLPF_NRO_TARJ_CRE { get; set; }

        public virtual CCOB_CLIE CLPF_CLIENTENavigation { get; set; } = null!;
    }
}
