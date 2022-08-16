using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminSurname { get; set; }
        public string AdminUserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string AdminAbout { get; set; }
        public string ImageUrl { get; set; }
        
    }
}
