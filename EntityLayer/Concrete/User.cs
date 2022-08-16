using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserUname { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string AdminAbout { get; set; }
        public string ImageUrl { get; set; }
        public bool UserStatus { get; set; }
        public List<Product> product { get; set; }

    }
}
