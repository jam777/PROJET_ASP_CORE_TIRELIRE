using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter;
using Tirelire_Jamal.Data;
using Tirelire_Jamal.Models;

namespace Tirelire_Jamal.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        Tirelire_JamContext _ctx;

        public Repository(Tirelire_JamContext ctx)
        {
            _ctx = ctx;
        }

        /// <summary>
        /// Recuperer toutes les lignnes de la table
        /// </summary>
        /// <returns>List d'entité</returns>
        public IEnumerable<T> FindAll()
        {
            return _ctx.Set<T>().ToList<T>();
        }

        /// <summary>
        /// Recupère un enregistrement de la table
        /// </summary>
        /// <param name="id">id du produit</param>
        /// <returns>Renvoie une entité ou null</returns>
        public T FindOne(int id)
        {

            return _ctx.Set<T>().Find(id);

        }


        public void Remove(T ligne)
        {
            _ctx.Set<T>().Remove(ligne);
            _ctx.SaveChanges();
        }

    }
}
