using EPR_MVC.Models;
using System.Linq;
using System.Web.Mvc;

namespace EPR_MVC.Controllers
{
    public class HomeController : Controller
    {
        public UserViewModel aUser = new UserViewModel();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Auth(UserViewModel user)
        {
            using (DBEPREntities db = new DBEPREntities())
            {
                USER account = db.USERS.SingleOrDefault(u => u.Username == user.Username && u.Password == user.Password);

                PartsViewModel pvm = new PartsViewModel();

                return Json("", JsonRequestBehavior.AllowGet);
            }
        }
    }
}