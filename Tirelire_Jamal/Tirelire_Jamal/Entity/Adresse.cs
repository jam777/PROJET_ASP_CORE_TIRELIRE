using System;
using System.Collections.Generic;

namespace Tirelire_Jamal
{
    public partial class Adresse
    {
        public Adresse()
        {
            Client = new HashSet<Client>();
        }

        public int Id { get; set; }
        public string AdLivraison { get; set; }
        public string AdFacturation { get; set; }

        public virtual ICollection<Client> Client { get; set; }
    }
}
