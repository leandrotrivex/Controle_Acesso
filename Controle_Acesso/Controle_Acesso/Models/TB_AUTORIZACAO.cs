//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Controle_Acesso.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_AUTORIZACAO
    {
        public int COD_AUTORIZACAO { get; set; }
        public string NOME_RESPONSAVEL { get; set; }
        public string RG { get; set; }
        public System.DateTime DATA { get; set; }
        public System.TimeSpan HORA { get; set; }
        public string TIPO_AUTORIZACAO { get; set; }
        public string VIGENCIA_INICIO { get; set; }
        public string VIGENCIA_FIM { get; set; }
        public string MOTIVO { get; set; }
        public Nullable<int> COD_ALUNO { get; set; }
    
        public virtual TB_ALUNO TB_ALUNO { get; set; }
    }
}
