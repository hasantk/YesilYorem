using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YesilYörem.ViewComponents.Shop
{
    public class CategoryBar: ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();  
        }

    }
}
