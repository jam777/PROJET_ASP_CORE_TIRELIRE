using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tirelire_Jamal.Models;

namespace Tirelire_Jamal.ViewModels
{
    public class DetailColorViewModel
    {
        public Produit produit { get; set; }
        public List<Produit> colorProduit { get; set; }

    }
}
