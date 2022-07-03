using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internative_Entity.Concrete
{
    public class User:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
