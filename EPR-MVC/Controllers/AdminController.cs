using EPR_MVC.Models;
using System.Linq;
using System.Web.Mvc;

namespace EPR_MVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Users()
        {
            using (DBEPREntities db = new DBEPREntities())
            {

                UserViewModel uvm = new UserViewModel();
                uvm.userList = db.USERS.Include("UZAUTOSUPPLIER").Where(u => u.IsDeleted == false).ToList();

                return View(uvm);
            }
        }
        public ActionResult User()
        {
            return View();
        }
    }
}