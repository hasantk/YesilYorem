using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YesilYörem.ViewComponents.CategoryList
{
    public class Category4List:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke() 
        {
            var values = cm.Get4list();
            return View(values);
        }
    }
}
