using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tirelire_Jamal.Models;

namespace Tirelire_Jamal.Calculs
{
    public interface ICalcul
    {
        public double ssTotal(DetailCommande detail);
    }
}
