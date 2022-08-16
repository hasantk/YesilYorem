using Microsoft.AspNetCore.Mvc;

namespace YesilYörem.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
