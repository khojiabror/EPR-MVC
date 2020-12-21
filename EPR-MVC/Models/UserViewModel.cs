using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EPR_MVC.Models
{
    public class UserViewModel
    {
        public int ID { get; set; }
        public int roleID { get; set; }
        [Required(ErrorMessage = "Loginni kiriting")]
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Kalit so'zini kiriting")]
        public string Password { get; set; }
        public bool Status { get; set; }
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