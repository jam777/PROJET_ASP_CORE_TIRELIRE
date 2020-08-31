using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tirelire_Jamal.Models;

namespace Tirelire_Jamal.Repository
{
    public interface IRepository<T>
    {
        //Récupère tous les objets
        IEnumerable<T> FindAll();

        //Récupère un objet
        T FindOne(int id);

        public void Remove(T ligne);



    }
}
