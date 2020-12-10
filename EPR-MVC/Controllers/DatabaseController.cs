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
                pvm.PartList = db.PARTS.Include("MACHINE").Include("SUPPLIER").Include("OEM").Include("UZAUTOSUPPLIER").Include("MANUFACTURER").Where(p => p.IsDeleted == false).ToList();

                return View(pvm);
            }
        }
        [HttpPost]
        public ActionResult PartsSave(PartsViewModel model)
        {
            using (DBEPREntities db = new DBEPREntities())
            {
                if (model.ID > 0)
                {
                    PART part = db.PARTS.SingleOrDefault(p => p.IsDeleted == false && p.ID == model.ID);
                    if (part != null)
                    {
                        part.ID = model.ID;
                        part.Name = model.Name;
                        part.NameRus = model.NameRus;
                        part.Description = model.Description;
                        part.DescriptionRus = model.DescriptionRus;
                        part.Code = model.DescriptionRus;
                        part.Currency = model.Currency;
                        part.Manufactured_Date = model.Manufactured_Date;
                        part.Modeli = model.Modeli;
                        part.OEMPartNumber = model.OEMPartNumber;
                        part.Price = model.Price;
                        part.SerialNumber = model.SerialNumber;
                        part.TechData = model.TechData;
                        part.Type = model.Type;
                        part.Unit = model.Unit;
                        part.MachineID = model.MachineID;
                        part.ManufacturerID = model.ManufacturerID;
                        part.SupplierID = model.SupplierID;
                        part.OEMID = model.OEMID;
                        part.UzAutoSupplierID = model.UzAutoSupplierID;

                        db.SaveChanges();
                    }
                }
                else
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
                }

                return View(model);
            }
        }
        public JsonResult PartsDelete(int partID)
        {
            bool result = false;
            using (DBEPREntities db = new DBEPREntities())
            {
                PART part = db.PARTS.SingleOrDefault(p => p.IsDeleted == false && p.ID == partID);
                if (part != null)
                {
                    part.IsDeleted = true;
                    db.SaveChanges();
                    result = true;
                }
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult PartsInsertOrEdit(int partID)
        {
            using (DBEPREntities db = new DBEPREntities())
            {
                PartsViewModel pvm = new PartsViewModel();
                //for Modals:
                List<SUPPLIER> sList = db.SUPPLIERS.Where(s => s.IsDeleted == false).ToList();
                ViewBag.SupplierList = new SelectList(sList, "ID", "Name");
                List<MACHINE> mList = db.MACHINES.Where(s => s.IsDeleted == false).ToList();
                ViewBag.MachineList = new SelectList(mList, "ID", "Name");
                List<MANUFACTURER> manList = db.MANUFACTURERS.Where(s => s.IsDeleted == false).ToList();
                ViewBag.ManufacturerList = new SelectList(manList, "ID", "Name");
                List<OEM> oList = db.OEMS.Where(s => s.IsDeleted == false).ToList();
                ViewBag.OEMList = new SelectList(oList, "ID", "Name");
                List<UZAUTOSUPPLIER> uList = db.UZAUTOSUPPLIERS.Where(s => s.IsDeleted == false).ToList();
                ViewBag.UzAutoSupplierList = new SelectList(uList, "ID", "Name");

                if (partID > 0)
                {
                    PART part = db.PARTS.SingleOrDefault(p => p.IsDeleted == false && p.ID == partID);
                    if (part != null)
                    {
                        pvm.ID = part.ID;
                        pvm.Name = part.Name;
                        pvm.NameRus = part.NameRus;
                        pvm.Description = part.Description;
                        pvm.DescriptionRus = part.DescriptionRus;
                        pvm.Code = part.Code;
                        pvm.Currency = part.Currency;
                        pvm.Manufactured_Date = part.Manufactured_Date;
                        pvm.PartNumber = part.PartNumber;
                        pvm.Modeli = part.Modeli;
                        pvm.OEMPartNumber = part.OEMPartNumber;
                        pvm.Price = part.Price;
                        pvm.SerialNumber = part.SerialNumber;
                        pvm.TechData = part.TechData;
                        pvm.Type = part.Type;
                        pvm.Unit = part.Unit;
                        pvm.MachineID = part.MachineID;
                        pvm.ManufacturerID = part.ManufacturerID;
                        pvm.SupplierID = part.SupplierID;
                        pvm.OEMID = part.OEMID;
                        pvm.UzAutoSupplierID = part.UzAutoSupplierID;
                    }
                }
                return PartialView("PartsInsertOrEdit", pvm);
            }
        }
        public ActionResult Machines()
        {
            using (DBEPREntities db = new DBEPREntities())
            {
                MachinesViewModel mvm = new MachinesViewModel();
                mvm.machineList = db.MACHINES.Include("MACHINETYPE").Include("UZAUTOSUPPLIER").Include("MANUFACTURER").Where(m => m.IsDeleted == false).ToList();

                return View(mvm);
            }
        }
        [HttpPost]
        public ActionResult MachinesSave(MachinesViewModel model)
        {
            using (DBEPREntities db = new DBEPREntities())
            {
                if (model.ID > 0)
                {
                    MACHINE machine = db.MACHINES.SingleOrDefault(m => m.IsDeleted == false && m.ID == model.ID);
                    if (machine != null)
                    {
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

                        db.SaveChanges();
                    }
                }
                else
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
                }
                return RedirectToAction("Machines");
            }
        }
        public JsonResult MachinesDelete(int machineID)
        {
            bool result = false;
            using (DBEPREntities db = new DBEPREntities())
            {
                MACHINE machine = db.MACHINES.SingleOrDefault(m => m.IsDeleted == false && m.ID == machineID);
                if (machine != null)
                {
                    machine.IsDeleted = true;
                    db.SaveChanges();
                    result = true;
                }
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult MachinesInsertOrEdit(int machineID)
        {
            using (DBEPREntities db = new DBEPREntities())
            {
                MachinesViewModel mvm = new MachinesViewModel();
                //for Modals:

                List<MANUFACTURER> manList = db.MANUFACTURERS.Where(s => s.IsDeleted == false).ToList();
                ViewBag.ManufacturerList = new SelectList(manList, "ID", "Name");
                List<MACHINETYPE> tList = db.MACHINETYPES.Where(s => s.IsDeleted == false).ToList();
                ViewBag.typeList = new SelectList(tList, "ID", "Name");
                List<UZAUTOSUPPLIER> uList = db.UZAUTOSUPPLIERS.Where(s => s.IsDeleted == false).ToList();
                ViewBag.UzAutoSupplierList = new SelectList(uList, "ID", "Name");

                if (machineID > 0)
                {
                    MACHINE machine = db.MACHINES.SingleOrDefault(m => m.IsDeleted == false && m.ID == machineID);
                    if (machine != null)
                    {
                        mvm.ID = machine.ID;
                        mvm.Name = machine.Name;
                        mvm.Description = machine.Description;
                        mvm.PartNumber = machine.PartNumber;
                        mvm.Lifespan = machine.Lifespan;
                        mvm.InstalledDate = machine.InstalledDate;
                        mvm.Status = machine.IsActive;
                        mvm.ManufacturerID = machine.ManufacturerID;
                        mvm.UzAutoSupplierID = machine.UzAutoSupplierID;
                        mvm.TypeID = machine.TypeID;
                    }
                }
                return PartialView("MachinesInsertOrEdit", mvm);
            }
        }
    }
}