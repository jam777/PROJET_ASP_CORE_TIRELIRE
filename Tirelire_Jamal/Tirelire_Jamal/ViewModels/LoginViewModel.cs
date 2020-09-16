using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tirelire_Jamal.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Veuillez entrer un email")]
        [EmailAddress(ErrorMessage = "L'email n'est pas valide")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Veuillez entrer un mot de passe")]
        public string Password { get; set; }

    }
}
