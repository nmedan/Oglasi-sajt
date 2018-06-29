using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oglasi.Models.AccountViewModels
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Ovo polje se mora popuniti.")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Ovo polje se mora popuniti.")]
        [EmailAddress(ErrorMessage = "Ovo polje se mora popuniti.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ovo polje se mora popuniti.")]
        [StringLength(100, ErrorMessage = "Lozinka mora da sadrži najmanje 6 karaktera", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Ovo polje se mora popuniti.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Unesene lozinke se ne poklapaju")]
        public string ConfirmPassword { get; set; }
    }
}
