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
    
    public partial class EntrepriseClient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EntrepriseClient()
        {
            this.Contrat = new HashSet<Contrat>();
            this.Interlocuteur = new HashSet<Interlocuteur>();
            this.TraductionEntreprise = new HashSet<TraductionEntreprise>();
        }
    
        public decimal numero { get; set; }
        public string denomination { get; set; }
        public string adresse { get; set; }
        public string numTel { get; set; }
        public decimal nombreTravailleursSoumis { get; set; }
        public decimal nombreTravailleursNonSoumis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrat> Contrat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Interlocuteur> Interlocuteur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraductionEntreprise> TraductionEntreprise { get; set; }
    }
}
