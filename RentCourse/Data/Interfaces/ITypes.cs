using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.Data.Interfaces
{
    public interface ITypes
    {
        IEnumerable<Models.Type> Types { get; }
    }
}
