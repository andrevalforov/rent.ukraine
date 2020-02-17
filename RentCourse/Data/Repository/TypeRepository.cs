using RentCourse.Data.EFContext;
using RentCourse.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.Data.Repository
{
    public class TypeRepository : ITypes
    {
        private readonly EFDbContext _context;
        public TypeRepository(EFDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Models.Type> Types => _context.Types;
    }
}
