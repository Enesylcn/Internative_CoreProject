using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Internative_Entity.Concrete
{
    public class Food
    {
        [Key]
        public int FoodID { get; set; }
        public string FoodName  { get; set; }
        public string FoodRecipe { get; set; }
        public string ImageURL { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}
