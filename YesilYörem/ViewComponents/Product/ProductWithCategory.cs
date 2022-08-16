using Microsoft.AspNetCore.Mvc;

namespace YesilYörem.ViewComponents.ProductWithCategory
{
    public class ProductWithCategory:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
