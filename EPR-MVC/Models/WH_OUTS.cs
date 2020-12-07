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
    
    public partial class WH_OUTS
    {
        public int ID { get; set; }
        public int PartID { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public int UserID { get; set; }
        public int WHID { get; set; }
        public int MachineID { get; set; }
        public string Comment { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual MACHINE MACHINE { get; set; }
        public virtual PART PART { get; set; }
        public virtual USER USER { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
