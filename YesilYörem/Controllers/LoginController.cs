using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace YesilYörem.Controllers
{

    public class LoginController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Admin t)
        {
            var Bilgi = c.Admins.FirstOrDefault(X => X.AdminUserName == t.AdminUserName &&
              X.Password == t.Password);
            if (Bilgi != null) 
            {
                var Claims = new List<Claim> 
                {
                    new Claim(ClaimTypes.Name,t.AdminUserName)
                };
                var useridentity=new ClaimsIdentity(Claims,"Login");
                ClaimsPrincipal principal=new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Home", "Yönetim");
            }
            return View();
        }
    }
}
