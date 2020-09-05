using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tirelire_Jamal.Models;
using Tirelire_Jamal.Repository;

namespace Tirelire_Jamal.Calculs
{
    public class Calcul : ICalcul
    {
        private IRepository<Produit> _repoProd;

        public Calcul(IRepository<Produit> repoProd)
        {
            _repoProd = repoProd;
        }

        public double ssTotal(DetailCommande detail)
        {
            var prod = _repoProd.FindOne(detail.Idproduit);
            double ssTotal = (detail.Prix + prod.Frais * prod.Poids) * detail.Quantite;

            return ssTotal;
        }
    }
}
