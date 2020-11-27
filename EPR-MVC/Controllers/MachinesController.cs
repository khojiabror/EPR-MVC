using EPR_MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EPR_MVC.Controllers
{
    public class MachinesController : Controller
    {
        // GET: Machines
        public ActionResult Index()
        {
            using (DBEPREntities db = new DBEPREntities())
            {
                List<MACHINE> machineList = db.MACHINES.ToList();

                MachinesViewModel mvm = new MachinesViewModel();

                List<MachinesViewModel> machineVMList = machineList.Select(m => new MachinesViewModel { Name = m.Name, Description = m.Description, PartNumber = m.PartNumber, Lifespan = m.Lifespan, InstalledDate = m.InstalledDate, Type = m.MACHINETYPE.Name, IsActive = m.IsActive, Manufacturer = m.MANUFACTURER.Name, UzAutoSupplier = m.UZAUTOSUPPLIER.Name }).ToList();

                return View(machineVMList);
            }
        }
    }
}