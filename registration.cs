//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class registration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public registration()
        {
            this.registrationevent = new HashSet<registrationevent>();
            this.sponsorship = new HashSet<sponsorship>();
        }
    
        public int RegistrationId { get; set; }
        public int RunnerId { get; set; }
        public System.DateTime RegistrationDateTime { get; set; }
        public string RaceKitOptionId { get; set; }
        public sbyte RegistrationStatusId { get; set; }
        public decimal Cost { get; set; }
        public int CharityId { get; set; }
        public decimal SponsorshipTarget { get; set; }
    
        public virtual charity charity { get; set; }
        public virtual racekitoption racekitoption { get; set; }
        public virtual runner runner { get; set; }
        public virtual registrationstatus registrationstatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<registrationevent> registrationevent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sponsorship> sponsorship { get; set; }
    }
}
