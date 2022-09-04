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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> Getlist()
        {
            return _categoryDal.GetListAll();
        }

        public List<Category> Get4list()
        {
            return _categoryDal.GetListAll().Take(4).ToList();
        }

        public List<Category> GetCategoryById(int id)
        {
            return _categoryDal.GetListAll(x => x.CategoryId == id);
        }

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
