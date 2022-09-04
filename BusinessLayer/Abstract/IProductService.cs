using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> GetListWithCategory();
        List<Product> GetProductListByUser(int id);
        List<Product> GetListCategory(int id);
    }
}
