using RentCourse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.ViewModels
{
    public class EditProductViewModel
    {
        public int ProductId { get; set; }
        public string UserId { get; set; }

        [Required(ErrorMessage = "Введіть заголовок")]
        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Введіть опис")]
        [Display(Name = "Опис")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Ціна")]
        public double Price { get; set; }

        [Display(Name = "Фото товару")]
        public string ImageName { get; set; }

        public FileModel fileModel { get; set; }
    }
}
