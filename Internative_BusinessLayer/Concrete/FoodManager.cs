using Internative_BusinessLayer.Abstract;
using Internative_DataAccessLayer.Abstract;
using Internative_Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internative_BusinessLayer.Concrete
{
    public class FoodManager : IGenericService<Food>
    {
        IFoodDal _foodDal;

        public FoodManager(IFoodDal foodDal)
        {
            _foodDal = foodDal;
        }

        public void TAdd(Food t)
        {
            _foodDal.Insert(t);
        }

        public void TDelete(Food t)
        {
            _foodDal.Delete(t);
        }

        public Food TGetByID(int id)
        {
            return _foodDal.GetByID(id);
        }

        public List<Food> TGetList()
        {
            return _foodDal.GetList();
        }

        public void TUpdate(Food t)
        {
            _foodDal.Update(t);
        }
    }
}
