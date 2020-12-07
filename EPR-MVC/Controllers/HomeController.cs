using EPR_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPR_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Auth()
        {
            //using (DBEPREntities db = new DBEPREntities())
            //{
            //    USER user = db.USERS.SingleOrDefault(u => u.Name);

            //    PartsViewModel pvm = new PartsViewModel();

            //    return View();
            //}   
            return View();
        }
    }
}