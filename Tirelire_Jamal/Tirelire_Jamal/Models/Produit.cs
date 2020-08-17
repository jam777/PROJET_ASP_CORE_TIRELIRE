using System;
using System.Collections.Generic;

namespace Tirelire_Jamal.Models
{
    public partial class Produit
    {
        public Produit()
        {
            Avis = new HashSet<Avis>();
            DetailCommande = new HashSet<DetailCommande>();
        }

        public int Id { get; set; }
        public double Hauteur { get; set; }
        public double Largeur { get; set; }
        public double Longueur { get; set; }
        public double Poids { get; set; }
        public int Capacite { get; set; }
        public string Description { get; set; }
        public int Idcouleur { get; set; }
        public int Idfabricant { get; set; }
        public double Prix { get; set; }
        public string Image { get; set; }
        public double Frais { get; set; }
        public bool Disponible { get; set; }
        public int Reference { get; set; }
        public string Nom { get; set; }

        public virtual Couleur IdcouleurNavigation { get; set; }
        public virtual Fabricant IdfabricantNavigation { get; set; }
        public virtual ICollection<Avis> Avis { get; set; }
        public virtual ICollection<DetailCommande> DetailCommande { get; set; }
    }
}
