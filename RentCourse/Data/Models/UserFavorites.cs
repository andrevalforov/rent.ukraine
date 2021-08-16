using RentCourse.Data.EFContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.Data.Models
{
    public class UserFavorites
    {
        public string UserId { get; set; }
        public DbUser User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
