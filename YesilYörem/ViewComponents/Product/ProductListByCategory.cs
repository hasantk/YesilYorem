using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace YesilYörem.ViewComponents.Product
{
    public class ProductListByCategory : ViewComponent
    {

        ProductManager pm = new ProductManager(new EfProductRepository());

        public IViewComponentResult Invoke(int id)
        {
            var value = pm.GetListCategory(id);
            return View(value);
        }
    }
}
