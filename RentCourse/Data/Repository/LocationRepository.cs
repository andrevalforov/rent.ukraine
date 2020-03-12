using RentCourse.Data.EFContext;
using RentCourse.Data.Interfaces;
using RentCourse.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.Data.Repository
{
    public class LocationRepository : ILocations
    {
        private readonly EFDbContext _context;
        public LocationRepository(EFDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Location> Locations => _context.Locations;
    }
}
