using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPR_MVC.Models
{
    public class PartsViewModel
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PartNumber { get; set; }
        public byte[] Photo { get; set; }
        public string UzAutoSupplierName { get; set; }
        public string NamePlate { get; set; }
        public string ManufacturerName { get; set; }
        public string SupplierName { get; set; }
        public string OEMName { get; set; }
        public string MachineName { get; set; }
    }
}