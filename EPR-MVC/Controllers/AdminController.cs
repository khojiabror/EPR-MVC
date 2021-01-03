using EPR_MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Data.SqlClient;
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
        public ActionResult UserAE()
        {
           
            using (DBEPREntities db = new DBEPREntities())
            {
                UserViewModel uvm = new UserViewModel();
                List<ROLE> rList = db.ROLES.Where(r => r.IsDeleted == false).ToList();
                ViewBag.roleList = new SelectList(rList, "ID", "RoleName");
                List<UZAUTOSUPPLIER> uList = db.UZAUTOSUPPLIERS.Where(s => s.IsDeleted == false).ToList();
                ViewBag.UzAutoSupplierList = new SelectList(uList, "ID", "Name");

                return View(uvm);
            }
        }
        [HttpPost]
        public ActionResult UserSave(UserViewModel model)
        {
            ///////////////////////////////////////////
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=89.236.217.150;Initial Catalog=DBEPR;User ID=EPRuser;Password=Zxcv!123";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            string sql = @"INSERT INTO testtable (id,test) VALUES ('xxxx','ZZZ')";
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            cnn.Close();
            ////////////////////////////////////////////

            using (DBEPREntities db = new DBEPREntities())
            {
                if (model.ID > 0)
                {
                    USER user = db.USERS.SingleOrDefault(p => p.IsDeleted == false && p.ID == model.ID);
                    if (user != null)
                    {
                        user.ID = model.ID;

                        db.SaveChanges();
                    }
                }
                else
                {
                    USER u = new USER();

                    u.Username = model.Username;
                    u.Name = model.Name;
                    u.Password = model.Password;
                    u.Email = model.Email;
                    u.Status = model.Status;
                    u.UzautosupplierID = model.UzautosupplierID;
                    u.Department = model.Department;
                    u.JobTitle = model.JobTitle;
                    u.Telephone = model.Telephone;
                    
                    db.USERS.Add(u);
                    db.SaveChanges();
                }

                return View(model);
            }

        }
    }
}