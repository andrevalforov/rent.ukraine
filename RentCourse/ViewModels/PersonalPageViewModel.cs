using Microsoft.AspNetCore.Http;
using RentCourse.Data.EFContext;
using RentCourse.Data.Models;
using RentCourse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.ViewModels
{
    public class PersonalPageViewModel
    {
        public DbUser User { get; set; }
        public UserProfile UserProfile { get; set; }


        [Required(ErrorMessage = "Введіть ім'я")]
        [RegularExpression(@"[а-яА-ЯёЁa-zA-ZіІїЇ\']+",
        ErrorMessage = "Некоректний формат даних")]
        public string FName { get; set; }
        
        [Required(ErrorMessage = "Введіть прізвище")]
        [RegularExpression(@"[а-яА-ЯёЁa-zA-ZіІїЇ\']+",
        ErrorMessage = "Некоректний формат даних")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Введіть email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$",
        ErrorMessage = "Некоректний формат email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введіть номер телефону")]
        [RegularExpression(@"^\+?3?8?(0\d{9})$",
        ErrorMessage = "Некоректний формат телефону")]
        public string PhoneNumber { get; set; }

        public FileModel fileModel { get; set; }
    }
}
