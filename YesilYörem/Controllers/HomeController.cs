using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using YesilYörem.Models;

namespace YesilYörem.Controllers
{

    public class HomeController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        Context c = new Context();
        public IActionResult Index() 
        {
            var values = pm.GetListWithCategory();
            return View(values);
        }

    }
}
