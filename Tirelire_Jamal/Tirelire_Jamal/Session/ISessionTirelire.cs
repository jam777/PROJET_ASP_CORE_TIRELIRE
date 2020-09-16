using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tirelire_Jamal.ViewModels;

namespace Tirelire_Jamal.Session
{
    public interface ISessionTirelire
    {
        //Désérialize la session en cours
        public PanierSessionViewModel deserialise();

        //Récupère le total de produits dans le panier
        public int totalPanier();

        //La quantite pour un produit
        public int quantitePanier(int id);

        //Effacer la session
        public void clearSession();
    }


}
