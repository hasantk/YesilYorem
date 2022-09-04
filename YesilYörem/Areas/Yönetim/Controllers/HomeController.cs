using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace YesilYörem.Areas.Yönetim.Controllers
{
    [Area("Yönetim")]
    public class HomeController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        public IActionResult Index(int page = 1)
        {
            var values = pm.GetListWithCategory().ToPagedList(page, 5);
            return View(values);
        }
    }
}
