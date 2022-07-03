using Internative_DataAccessLayer.Abstract;
using Internative_DataAccessLayer.Repository;
using Internative_Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internative_DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
}
