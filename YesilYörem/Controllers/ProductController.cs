using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YesilYörem.Controllers
{
    public class ProductController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int id)
        {

            ViewBag.i = id;
            var values = cm.GetCategoryById(id);
            return View(values);
        }
    }
}
