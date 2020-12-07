using System;
using System.Collections.Generic;

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
        public int UzAutoSupplierID { get; set; }
        public byte[] NamePlate { get; set; }
        public int ManufacturerID { get; set; }
        public int SupplierID { get; set; }
        public int OEMID { get; set; }
        public int MachineID { get; set; }
        public string OEMPartNumber { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }
        public DateTime? Manufactured_Date { get; set; }
        public string NameRus { get; set; }
        public string DescriptionRus { get; set; }
        public string TechData { get; set; }
        public string Unit { get; set; }
        public double? Price { get; set; }
        public string Currency { get; set; }

        public List<PART> PartList { get; set; }
    }
}