using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Введіть email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Введіть пароль")]
        public string Password { get; set; }
    }
}
