using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.ViewModels
{
    public class IndexPageViewModel
    {
        public string Search { get; set; }
        [Required]
        public int TypeId { get; set; }

        public IEnumerable<RentCourse.Data.Models.Type> GetTypes { get; set; }
    }
}
