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
    using System.ComponentModel;
    public partial class ContratTravailleurSoumis
    {
        [DisplayName("id contrat soumis")]
        public decimal idContrat { get; set; }
        [DisplayName("Num�ro de dossier m�dical")]
        public string numDossierMedical { get; set; }
    
        public virtual Contrat Contrat { get; set; }
    }
}
