using Microsoft.AspNetCore.Identity;
using RentCourse.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.Data.EFContext
{
    public class DbUser : IdentityUser<string>
    {
        public ICollection<DbUserRole> UserRoles { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public ICollection<UserFavorites> UserFavorites { get; set; }
    }
}
