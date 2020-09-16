using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace Tirelire_Jamal.ViewModels
{
    public class RegisterViewModel : LoginViewModel
    {
        [StringLength(12, ErrorMessage = "Le Username est compris entre 3 et {1} caractères", MinimumLength = 3)]
        [Required(ErrorMessage = "Veuillez entrer un Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Veuillez entrer un Nom")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Veuillez entrer un Prénom")]
        public string Prenom { get; set; }


        [Required(ErrorMessage = "Veuillez entrer un mot de passe")]
        [RegularExpression(@"^[a-zA-Z0-9#$^+=!*()@%&]{8,}$",
         ErrorMessage = "Le mot de passe doit contenir au moins 8 carateres alphanumériques ")]
        public new string Password { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Veuillez entrer un email")]
        public new string Email { get; set; }

        [Required(ErrorMessage = "Veuillez entrer une date de naissance")]
        public string DateNaissance { get; set; }

        [RegularExpression(@"([0-9]{2}-){4}[0-9]{2}", ErrorMessage = "Votre téléphone doit avoir ce format : 01-02-03-04-05")]
        [Required(ErrorMessage = "Veuillez entrer un Numéro de téléphone")]
        public string Telephone { get; set; }

        public bool Genre { get; set; }

        [Required(ErrorMessage = "Veuillez entrer une adresse de livraison")]
        public string AdresseLivraison { get; set; }

        [Required(ErrorMessage = "Veuillez entrer une adresse de facturation")]
        public string AdresseFacturation { get; set; }
        public string RoleName { get; set; }
    }
}
