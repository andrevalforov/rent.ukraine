using RentCourse.Data.EFContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.ViewModels
{
    public class AddProductViewModel
    {
        [Required]
        [Display(Name ="Тип")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Категорія")]
        public int CategotyId { get; set; }

        [Required]
        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Опис")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Ціна")]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Місцезнаходження")]
        public string Location { get; set; }

        [Display(Name = "Фото товару")]
        public string ImageName { get; set; }
    }
}
