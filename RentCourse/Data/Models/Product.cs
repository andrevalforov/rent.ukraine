﻿using RentCourse.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<string> Images { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Available { get; set; }
        public DateTime DateOfPublication { get; set; }
        public int ViewCount { get; set; }
        public string Location { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int UserId { get; set; }
        public virtual UserProfile User { get; set; }
    }
}
