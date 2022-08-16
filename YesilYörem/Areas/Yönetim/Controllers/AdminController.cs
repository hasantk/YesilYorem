using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace YesilYörem.Areas.Yönetim.Controllers
{
    [Area("Yönetim")]
    public class AdminController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        
        public IActionResult Index()
        {
            return View();
        }

    }
}
