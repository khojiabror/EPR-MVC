using EPR_MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EPR_MVC.Controllers
{
    public class DatabaseController : Controller
    {
        // GET: Database
        public ActionResult Parts()
        {
            using (DBEPREntities db = new DBEPREntities())
            {

                PartsViewModel pvm = new PartsViewModel();
                pvm.PartList = db.PARTS.Include("MACHINE").Include("SUPPLIER").Include("OEM").Include("UZAUTOSUPPLIER").Include("MANUFACTURER").Where(p => p.IsDeleted == false).ToList();//partList.Select(p => new PartsViewModel { Code = p.Code, Name = p.Name, Description = p.Description, PartNumber = p.PartNumber, OEMPartNumber = p.OEMPartNumber, NamePlate = p.NamePlate, MachineName = p.MACHINE.Name, SupplierName = p.SUPPLIER.Name, OEMName = p.OEM.Name, ManufacturerName = p.MANUFACTURER.Name, UzAutoSupplierName = p.UZAUTOSUPPLIER.Name }).ToList();
                //for Modals:
                List<SUPPLIER> sList = db.SUPPLIERS.ToList();
                ViewBag.SupplierList = new SelectList(sList, "ID", "Name");
                List<MACHINE> mList = db.MACHINES.ToList();
                ViewBag.MachineList = new SelectList(mList, "ID", "Name");
                List<MANUFACTURER> manList = db.MANUFACTURERS.ToList();
                ViewBag.ManufacturerList = new SelectList(manList, "ID", "Name");
                List<OEM> oList = db.OEMS.ToList();
                ViewBag.OEMList = new SelectList(oList, "ID", "Name");
                List<UZAUTOSUPPLIER> uList = db.UZAUTOSUPPLIERS.ToList();
                ViewBag.UzAutoSupplierList = new SelectList(uList, "ID", "Name");

                return View(pvm);
            }
        }
        [HttpPost]
        public ActionResult PartsInsert(PartsViewModel model)
        {
            using (DBEPREntities db = new DBEPREntities())
            {
                PART p = new PART();

                p.Code = model.Code;
                p.Description = model.Description;
                p.DescriptionRus = model.DescriptionRus;
                p.MachineID = model.MachineID;
                p.SupplierID = model.SupplierID;
                p.OEMID = model.OEMID;
                p.ManufacturerID = model.ManufacturerID;
                p.UzAutoSupplierID = model.UzAutoSupplierID;
                p.PartNumber = model.PartNumber;
                p.OEMPartNumber = model.OEMPartNumber;
                //p.NamePlate = model.NamePlate;
                p.Name = model.Name;
                p.NameRus = model.NameRus;
                p.Modeli = model.Modeli;
                p.Type = model.Type;
                p.SerialNumber = model.SerialNumber;
                p.Manufactured_Date = model.Manufactured_Date;
                p.TechData = model.TechData;
                p.Unit = model.Unit;
                p.Price = model.Price;
                p.Currency = model.Currency;
                p.IsDeleted = false;

                db.PARTS.Add(p);
                db.SaveChanges();

                return RedirectToAction("Parts");
            }
        }
        public JsonResult PartsDelete(int PartID)
        {
            bool result = false;
            using (DBEPREntities db = new DBEPREntities())
            {
                PART part = db.PARTS.SingleOrDefault(p => p.IsDeleted == false && p.ID == PartID);
                if (part != null)
                {
                    part.IsDeleted = true;
                    db.SaveChanges();
                    result = true;
                }
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Machines()
        {
            using (DBEPREntities db = new DBEPREntities())
            {
                MachinesViewModel mvm = new MachinesViewModel();
                mvm.machineList = db.MACHINES.Include("MACHINETYPE").Include("UZAUTOSUPPLIER").Include("MANUFACTURER").Where(m => m.IsDeleted == false).ToList();

                List<MANUFACTURER> manList = db.MANUFACTURERS.ToList();
                ViewBag.ManufacturerList = new SelectList(manList, "ID", "Name");
                List<MACHINETYPE> tList = db.MACHINETYPES.ToList();
                ViewBag.typeList = new SelectList(tList, "ID", "Name");
                List<UZAUTOSUPPLIER> uList = db.UZAUTOSUPPLIERS.ToList();
                ViewBag.UzAutoSupplierList = new SelectList(uList, "ID", "Name");

                return View(mvm);
            }
        }
        [HttpPost]
        public ActionResult MachinesInsert(MachinesViewModel model)
        {
            using (DBEPREntities db = new DBEPREntities())
            {
                MACHINE machine = new MACHINE();

                machine.Name = model.Name;
                machine.Description = model.Description;
                machine.Lifespan = model.Lifespan;
                machine.InstalledDate = model.InstalledDate;
                machine.PartNumber = model.PartNumber;
                if (model.Status)
                    machine.IsActive = true;
                else
                    machine.IsActive = false;
                machine.ManufacturerID = model.ManufacturerID;
                machine.UzAutoSupplierID = model.UzAutoSupplierID;
                machine.TypeID = model.TypeID;
                machine.IsDeleted = false;

                db.MACHINES.Add(machine);
                db.SaveChanges();

                return RedirectToAction("Machines");
            }
        }
        public JsonResult MachinesDelete(int MachineID)
        {
            bool result = false;
            using (DBEPREntities db = new DBEPREntities())
            {
                MACHINE machine = db.MACHINES.SingleOrDefault(p => p.IsDeleted == false && p.ID == MachineID);
                if (machine != null)
                {
                    machine.IsDeleted = true;
                    db.SaveChanges();
                    result = true;
                }
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}