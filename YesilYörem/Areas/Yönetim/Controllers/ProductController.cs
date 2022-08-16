using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace YesilYörem.Areas.Yönetim.Controllers
{
    [Area("Yönetim")]
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        UserManager um = new UserManager(new EfUserRepository());
        Context c = new Context();

        public IActionResult Index()
        {
            var values = pm.GetListWithCategory();
            return View(values);
        }



        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> categorylist = (from x in cm.Getlist()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CategoryName,
                                                     Value=x.CategoryId.ToString()
                                                 }).ToList();
            List<SelectListItem> userList = (from x in um.Getlist()
                                             select new SelectListItem
                                             {
                                                 Text=x.UserUname,
                                                 Value=x.UserId.ToString()
                                             }).ToList();
            ViewBag.ul = userList;
            ViewBag.cl = categorylist;
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            p.ProductStatus = true;
            p.ProductCreateTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            pm.TAdd(p);
            return RedirectToAction("Index","Product");
        }

        public ActionResult DeleteProduct(int id) 
        {
            var productvalue = pm.TGetById(id);
            pm.TDelete(productvalue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id) 
        {
            List<SelectListItem> categorylist = (from x in cm.Getlist()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CategoryName,
                                                     Value = x.CategoryId.ToString()
                                                 }).ToList();
            List<SelectListItem> userList = (from x in um.Getlist()
                                             select new SelectListItem
                                             {
                                                 Text = x.UserUname,
                                                 Value = x.UserId.ToString()
                                             }).ToList();
            ViewBag.ul = userList;
            var productvalue = pm.TGetById(id);
            ViewBag.cl = categorylist;
            return View(productvalue);
        }

        public IActionResult Test() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product p) 
        {
            var productvalue = pm.TGetById(p.ProductId);
            p.UserId = 1;
            p.ProductCreateTime= DateTime.Parse(p.ProductCreateTime.ToShortDateString());  
            p.ProductStatus = true;
            pm.TUpdate(p);
            return RedirectToAction("Index");
         
        }
    }
}
