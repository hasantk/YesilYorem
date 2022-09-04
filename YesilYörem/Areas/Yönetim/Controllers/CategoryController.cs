using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace YesilYörem.Areas.Yönetim.Controllers
{
    [Area("Yönetim")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page=1)
        {
            var value = cm.Getlist().ToPagedList(page,5);
            return View(value);
        }

        public IActionResult DeleteCategory(int id) 
        {
            var value = cm.TGetById(id);
            cm.TDelete(value);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCategory(int id)
        {
            var value = cm.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category t)
        {
            cm.TUpdate(t);
            return RedirectToAction("Index","Category");
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            cm.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}
