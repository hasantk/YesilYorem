using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public List<Product> GetListWithCategory()
        {
            return _productDal.GetListWithCategory();
        }

        public List<Product> ProductLast3Post()
        {
            return _productDal.GetListAll().Take(3).ToList();
        }

        public List<Product> GetProductListByUser(int id)
        {
            return _productDal.GetListWithCategoryByUser(id);
        }

        public void TAdd(Product t)
        {
            _productDal.Insert(t);
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }

        public List<Product> Getlist()
        {
            return _productDal.GetListAll();
        }

        public List<Product> GetListCategory(int id)
        {
            return _productDal.GetListAll(x => x.CategoryId == id);
        }
    }
}
