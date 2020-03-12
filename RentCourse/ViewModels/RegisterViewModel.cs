using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Прізвище")]
        [RegularExpression(@"[a-zA-Z]+",
        ErrorMessage = "Некоректний формат даних")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Ім'я")]
        [RegularExpression(@"[a-zA-Z]+",
        ErrorMessage = "Некоректний формат даних")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "По-батькові")]
        [RegularExpression(@"[a-zA-Z]+",
        ErrorMessage = "Некоректний формат даних")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$",
        ErrorMessage = "Некоректний формат email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Номер телефону")]
        [RegularExpression(@"^\+?3?8?(0\d{9})$",
        ErrorMessage = "Некоректний формат телефону")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,24}$",
        ErrorMessage = "Некоректний формат паролю")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Паролі не співпадають")]
        [DataType(DataType.Password)]
        [Display(Name = "Підтвердіть пароль")]
        public string PasswordConfirm { get; set; }
    }
}
