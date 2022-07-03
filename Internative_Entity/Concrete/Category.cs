using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Internative_Entity.Concrete
{
   public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        //public string CategoryImage { get; set; } Bunu Ekle 
        public ICollection<Food> Foods { get; set; }
    }
}
