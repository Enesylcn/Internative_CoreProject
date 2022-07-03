using Internative_BusinessLayer.Concrete;
using Internative_DataAccessLayer.EntityFramework;
using Internative_Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internative_CoreUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DefaultController : Controller
    {
        
        FoodManager fm = new FoodManager(new EfFoodDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var values = fm.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddRecipe()
        {
            List<SelectListItem> cateValu = (from x in cm.TGetList()
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryID.ToString()
                                             }).ToList();
            ViewBag.vc = cateValu;

            return View();
        }
        [HttpPost]
        public IActionResult AddRecipe(Food food)
        {
            List<SelectListItem> cateValu = (from x in cm.TGetList()
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryID.ToString()
                                             }).ToList();
            ViewBag.vc = cateValu;
            fm.TAdd(food);

            return RedirectToAction("Index","Default");
        }

       
      
        
        public IActionResult DeleteRecipe(int id)
        {
            var values = fm.TGetByID(id);
            fm.TDelete(values);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateRecipe(int id)
        {
            var values = fm.TGetByID(id);
            fm.TUpdate(values);

            return RedirectToAction("Index", "Default");
        }

    }
}
