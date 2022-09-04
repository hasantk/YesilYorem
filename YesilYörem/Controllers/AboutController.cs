using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YesilYörem.Controllers
{

    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
