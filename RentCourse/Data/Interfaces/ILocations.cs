using RentCourse.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.Data.Interfaces
{
    public interface ILocations
    {
        IEnumerable<Location> Locations { get; }
    }
}
