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
    
    public partial class TB_ALUNO_TURMA
    {
        public int COD_ALUNO { get; set; }
        public int COD_TURMA { get; set; }
        public string ANO { get; set; }
        public string SEMESTRE { get; set; }
    
        public virtual TB_ALUNO TB_ALUNO { get; set; }
        public virtual TB_TURMA TB_TURMA { get; set; }
    }
}
