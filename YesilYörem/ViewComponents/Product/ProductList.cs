using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YesilYörem.ViewComponents.Product
{
    public class ProductList:ViewComponent
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        public IViewComponentResult Invoke() 
        {
            var values = pm.Getlist();
            return View(values);
        }
    }
}
