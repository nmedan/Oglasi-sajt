using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oglasi.Models.AccountViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Ovo polje se mora popuniti.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Ovo polje se mora popuniti.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
