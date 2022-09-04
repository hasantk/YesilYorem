using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YesilYörem.Controllers
{

    public class ShopSingleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
