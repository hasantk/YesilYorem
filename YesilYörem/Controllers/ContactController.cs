using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YesilYörem.Controllers
{

    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
