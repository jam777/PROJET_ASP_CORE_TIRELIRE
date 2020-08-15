﻿using System;
using System.Collections.Generic;

namespace Tirelire_Jamal
{
    public partial class Client
    {
        public Client()
        {
            Avis = new HashSet<Avis>();
            Commande = new HashSet<Commande>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public bool Active { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Telephone { get; set; }
        public bool Genre { get; set; }
        public int? Idadresse { get; set; }

        public virtual Adresse IdadresseNavigation { get; set; }
        public virtual ICollection<Avis> Avis { get; set; }
        public virtual ICollection<Commande> Commande { get; set; }
    }
}
