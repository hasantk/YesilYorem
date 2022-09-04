using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YesilYörem.Controllers
{

    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
