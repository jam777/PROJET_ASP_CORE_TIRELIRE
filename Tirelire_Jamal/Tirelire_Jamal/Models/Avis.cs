using System;
using System.Collections.Generic;

namespace Tirelire_Jamal.Models
{
    public partial class Avis
    {
        public int Id { get; set; }
        public int Idproduit { get; set; }
        public string Idclient { get; set; }
        public bool? Valide { get; set; }

        public virtual Commande IdNavigation { get; set; }
        public virtual AspNetUsers IdclientNavigation { get; set; }
        public virtual Produit IdproduitNavigation { get; set; }
    }
}
