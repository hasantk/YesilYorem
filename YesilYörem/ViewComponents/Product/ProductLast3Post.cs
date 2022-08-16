using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YesilYörem.ViewComponents.Product
{
    public class ProductLast3Post:ViewComponent
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        public IViewComponentResult Invoke()
        {
            var values = pm.ProductLast3Post();
            return View(values);
        }
    }
}
