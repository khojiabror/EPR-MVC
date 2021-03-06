//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPR_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            this.LOGS = new HashSet<LOG>();
            this.ORDERS = new HashSet<ORDER>();
            this.USERSIMAGES = new HashSet<USERSIMAGE>();
            this.WAREHOUSES = new HashSet<Warehouse>();
            this.WH_INS = new HashSet<WH_INS>();
            this.WH_OUTS = new HashSet<WH_OUTS>();
            this.ROLES = new HashSet<ROLE>();
        }
    
        public int ID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public Nullable<bool> IsOnline { get; set; }
        public int UzautosupplierID { get; set; }
        public string Telephone { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOG> LOGS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER> ORDERS { get; set; }
        public virtual UZAUTOSUPPLIER UZAUTOSUPPLIER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USERSIMAGE> USERSIMAGES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warehouse> WAREHOUSES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WH_INS> WH_INS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WH_OUTS> WH_OUTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROLE> ROLES { get; set; }
    }
}
