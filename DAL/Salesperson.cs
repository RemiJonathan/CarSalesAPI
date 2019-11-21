//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Salesperson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Salesperson()
        {
            this.Sales = new HashSet<Sale>();
        }
    
        public int SalespersonId { get; set; }
        public string SalespersonFname { get; set; }
        public string SalespersonLname { get; set; }
        public string SalespersonEmail { get; set; }
        public string SalespersonPhone { get; set; }
        public string SalespersonAddressCivicNo { get; set; }
        public string SalespersonAddressStreetName { get; set; }
        public string SalespersonAddressAppartment { get; set; }
        public string SalespersonAddressCity { get; set; }
        public string SalespersonAddressProvince { get; set; }
        public string SalespersonAddressPostalCode { get; set; }
        public int LocationId { get; set; }
        public bool Active { get; set; }
    
        public virtual Location Location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
