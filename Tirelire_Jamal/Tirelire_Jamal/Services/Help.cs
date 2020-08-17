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
        public static string file_color(string file)
        {
            int pos = file.IndexOf("_") + 1;
            var col = file.Substring(pos);
            pos = col.IndexOf(".");
            col = col.Substring(0, pos);
            return col;
        }

        public static int image_idcolor(HashSet<string> couleur, string image)
        {
            int cpt = 1;
            string imgColor = file_color(image);

            foreach (var col in couleur)
            {
                if (imgColor == col)
                {
                    break;
                }
                else { cpt++; }

            }

            return cpt;
        }

        public static void removeTable<TEntity>(this Microsoft.EntityFrameworkCore.DbSet<TEntity> test) where TEntity : class
        {
            foreach (var item in test)
            {
                test.Remove(item);
            }

        }
    }
}
