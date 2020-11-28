using EPR_MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EPR_MVC.Controllers
{
    public class PartsController : Controller
    {
        // GET: Parts
        public ActionResult Index()
        {
            using (DBEPREntities db = new DBEPREntities())
            {
                List<PART> partList = db.PARTS.ToList();

                PartsViewModel pvm = new PartsViewModel();

                List<PartsViewModel> partVMList = partList.Select(p => new PartsViewModel { Code = p.Code, Name = p.Name, Description = p.Description, PartNumber = p.PartNumber, OEMPartNumber = p.OEMPartNumber, NamePlate = p.NamePlate, MachineName = p.MACHINE.Name, SupplierName = p.SUPPLIER.Name, OEMName = p.OEM.Name, ManufacturerName = p.MANUFACTURER.Name, UzAutoSupplierName = p.UZAUTOSUPPLIER.Name }).ToList();
                return View(partVMList);
            }
        }
    }
}