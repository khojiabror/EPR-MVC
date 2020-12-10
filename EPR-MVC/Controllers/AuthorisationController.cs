using EPR_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPR_MVC.Controllers
{
    public class AuthorisationController : Controller
    {
        // GET: Authorisation
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Auth(UserViewModel model)
        {
            using (DBEPREntities db = new DBEPREntities())
            {
                USER user = db.USERS.SingleOrDefault(u => u.Username == model.Username && u.IsDeleted == false);

                PartsViewModel pvm = new PartsViewModel();

                return RedirectToAction("Index");
            }
        }
    }
}