using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Введіть прізвище")]
        [Display(Name = "Прізвище")]
        [RegularExpression(@"[а-яА-ЯёЁa-zA-ZіІїЇ\']+",
        ErrorMessage = "Некоректний формат даних")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Введіть ім'я")]
        [Display(Name = "Ім'я")]
        [RegularExpression(@"[а-яА-ЯёЁa-zA-ZіІїЇ\']+",
        ErrorMessage = "Некоректний формат даних")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Введіть по-батькові")]
        [Display(Name = "По-батькові")]
        [RegularExpression(@"[а-яА-ЯёЁa-zA-ZіІїЇ\']+",
        ErrorMessage = "Некоректний формат даних")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Введіть email")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$",
        ErrorMessage = "Некоректний формат email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введіть номер телефону")]
        [Display(Name = "Номер телефону")]
        [RegularExpression(@"^\+?3?8?(0\d{9})$",
        ErrorMessage = "Некоректний формат телефону")]
        public string PhoneNumber { get; set; }

        public bool Viber { get; set; }

        public bool WhatsApp { get; set; }

        public bool Telegram { get; set; }

        [RegularExpression(@"[A-Za-z0-9_]+",
        ErrorMessage = "Некоректний формат даних")]
        public string TgUsername { get; set; }

        [Required(ErrorMessage = "Введіть пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,24}$",
        ErrorMessage = "Некоректний формат паролю")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Повторіть пароль")]
        [Compare("Password", ErrorMessage = "Паролі не співпадають")]
        [DataType(DataType.Password)]
        [Display(Name = "Підтвердіть пароль")]
        public string PasswordConfirm { get; set; }
    }
}
