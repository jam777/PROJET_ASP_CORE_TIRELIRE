using System;
using System.Collections.Generic;

namespace Tirelire_Jamal.Models
{
    public partial class DetailCommande
    {
        public int Id { get; set; }
        public int Idproduit { get; set; }
        public int Idcommande { get; set; }
        public int Quantite { get; set; }
        public double Prix { get; set; }

        public virtual Commande IdcommandeNavigation { get; set; }
        public virtual Produit IdproduitNavigation { get; set; }
    }
}
