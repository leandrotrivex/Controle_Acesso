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
    
    public partial class TB_CARGO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_CARGO()
        {
            this.ACESSO = new HashSet<ACESSO>();
        }
    
        public int COD_CARGO { get; set; }
        public string CARGO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACESSO> ACESSO { get; set; }
    }
}
