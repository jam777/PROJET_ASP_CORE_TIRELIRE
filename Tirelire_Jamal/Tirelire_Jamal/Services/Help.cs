using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Tirelire_Jamal
{
    public static class Help
    {
        /// <summary>
        /// Recupere un fichier x_rouge_jpg => rouge
        /// </summary>
        /// <param name="file">Nom du fichier image</param>
        /// <returns>Retoune une couleur</returns>
        public static string file_color(string file)
        {
            int pos = file.IndexOf("_") + 1;
            var col = file.Substring(pos);
            pos = col.IndexOf(".");
            col = col.Substring(0, pos);
            return col;


        }

        /// <summary>
        /// Permet de purger les tables pour la fixtures
        /// </summary>
        /// <typeparam name="T">Model de classe</typeparam>
        /// <param name="table">Collection d'objets entités</param>
        public static void removeTable<T>(this Microsoft.EntityFrameworkCore.DbSet<T> table) where T : class
        {
            foreach (var item in table)
            {
                table.Remove(item);
            }
        }

    }
}
