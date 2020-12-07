using System;
using System.Collections.Generic;

namespace EPR_MVC.Models
{
    public class MachinesViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int UzAutoSupplierID { get; set; }
        public int ManufacturerID { get; set; }
        public string Lifespan { get; set; }
        public bool IsActive { get; set; }
        public DateTime? InstalledDate { get; set; }
        public int TypeID { get; set; }
        public string PartNumber { get; set; }
        public int ID { get; set; }
        public bool Status { get; set; }

        public List<MACHINE> machineList { get; set; }
    }
}