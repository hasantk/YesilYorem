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
    public class BasketManager : IBasketService
    {
        IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public List<Basket> Getlist()
        {
            return _basketDal.GetListAll();
        }

        public void TAdd(Basket t)
        {
            _basketDal.Insert(t);
        }

        public void TDelete(Basket t)
        {
            _basketDal.Delete(t);
        }

        public Basket TGetById(int id)
        {
            return _basketDal.GetById(id);
        }

        public void TUpdate(Basket t)
        {
            _basketDal.Update(t);
        }
    }
}
