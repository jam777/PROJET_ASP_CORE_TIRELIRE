using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tirelire_Jamal.ViewModels
{
    public class RegisterViewModel:LoginViewModel
    {

        public string UserName { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }       
        public DateTime DateNaissance { get; set; }
        public string Telephone { get; set; }
        public bool Genre { get; set; }
        public string AdresseLivraison { get; set; }
        public string AdresseFacturation { get; set; }
        public string RoleName { get; set; }
    }
}
