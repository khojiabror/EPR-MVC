using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EPR_MVC.Models
{
    public class UserViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Loginni kiriting")]
        public string Username { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Kalit so'zini kiriting")]
        public string Password { get; set; }
        public bool Status { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public bool IsOnline { get; set; }
        public string Telephone { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        //public string Question { get; set; }
        //public string Answer { get; set; }
        //public Nullable<bool> IsOnline { get; set; }
        public int UzautosupplierID { get; set; }
        public List<USER> userList { get; set; }
    }
}