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
    
    public partial class PART
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PART()
        {
            this.ORDERS = new HashSet<ORDER>();
            this.PARTIMAGES = new HashSet<PARTIMAGE>();
            this.PARTNAMEPLATES = new HashSet<PARTNAMEPLATE>();
            this.WH_INS = new HashSet<WH_INS>();
            this.WH_OUTS = new HashSet<WH_OUTS>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PartNumber { get; set; }
        public int UzAutoSupplierID { get; set; }
        public int ManufacturerID { get; set; }
        public int SupplierID { get; set; }
        public int OEMID { get; set; }
        public int MachineID { get; set; }
        public string OEMPartNumber { get; set; }
        public string Modeli { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }
        public Nullable<System.DateTime> Manufactured_Date { get; set; }
        public string NameRus { get; set; }
        public string DescriptionRus { get; set; }
        public string TechData { get; set; }
        public string Unit { get; set; }
        public Nullable<double> Price { get; set; }
        public string Currency { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual MACHINE MACHINE { get; set; }
        public virtual MANUFACTURER MANUFACTURER { get; set; }
        public virtual OEM OEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER> ORDERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PARTIMAGE> PARTIMAGES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PARTNAMEPLATE> PARTNAMEPLATES { get; set; }
        public virtual SUPPLIER SUPPLIER { get; set; }
        public virtual UZAUTOSUPPLIER UZAUTOSUPPLIER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WH_INS> WH_INS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WH_OUTS> WH_OUTS { get; set; }
    }
}
