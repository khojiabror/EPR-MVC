using System;

namespace EPR_MVC.Models
{
    public class MachinesViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UzAutoSupplier { get; set; }
        public string Manufacturer { get; set; }
        public string Lifespan { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> InstalledDate { get; set; }
        public string Type { get; set; }
        public string PartNumber { get; set; }
        public int ID { get; set; }
    }
}