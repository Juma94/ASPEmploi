//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmploiASP_2
{
    using System;
    using System.Collections.Generic;
    
    public partial class TraductionProfession
    {
        public decimal idTraductionProfession { get; set; }
        public string codeAlphabetique { get; set; }
        public decimal idLangue { get; set; }
        public string TexteTradProfession { get; set; }
    
        public virtual Langue Langue { get; set; }
        public virtual Profession Profession { get; set; }
    }
}
