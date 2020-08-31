using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tirelire_Jamal.Services
{
    public interface ISessionTirelire
    {
        public PanierSession deserialise();

        public int totalPanier();

        public int quantitePanier(int id);
    }

    
}
