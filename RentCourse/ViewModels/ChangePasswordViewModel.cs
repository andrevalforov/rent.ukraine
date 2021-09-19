using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Введіть старий пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Старий пароль")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Введіть новий пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Новий пароль")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,24}$",
        ErrorMessage = "Некоректний формат паролю")]
        public string NewPassword { get; set; }
        
        [Required(ErrorMessage = "Підтвердьте новий пароль")]
        [Compare("NewPassword", ErrorMessage = "Паролі не співпадають")]
        [DataType(DataType.Password)]
        [Display(Name = "Підтвердьте пароль")]
        public string NewPasswordConfirm { get; set; }
    }
}
