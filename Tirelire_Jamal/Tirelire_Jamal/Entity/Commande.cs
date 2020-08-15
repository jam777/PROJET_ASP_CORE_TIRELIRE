﻿using System;
using System.Collections.Generic;

namespace Tirelire_Jamal
{
    public partial class Commande
    {
        public Commande()
        {
            DetailCommande = new HashSet<DetailCommande>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Idclient { get; set; }
        public string Commentaire { get; set; }
        public string Status { get; set; }

        public virtual Client IdclientNavigation { get; set; }
        public virtual ICollection<DetailCommande> DetailCommande { get; set; }
    }
}
