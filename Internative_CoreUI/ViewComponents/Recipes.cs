using Internative_BusinessLayer.Concrete;
using Internative_DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internative_CoreUI.ViewComponents
{
    public class Recipes : ViewComponent
    {
        FoodManager fm = new FoodManager(new EfFoodDal());
        public IViewComponentResult Invoke()
        {
            var values = fm.TGetList();
            return View(values);
        }
    }
}
