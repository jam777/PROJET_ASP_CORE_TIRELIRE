using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tirelire_Jamal
{
    public class Help
    {
        enum color
        {
            Blanc = 1,
            Rose,
            Gris,
            Marron,
            Vert,
            Argent
        }

        public static int color_produit(int i)
        {
            int res = 0;

            switch (i)
            {
                case 1: res = (int)color.Rose; break;
                case 2: res = (int)color.Blanc; break;
                case 3: res = (int)color.Blanc; break;
                case 4: res = (int)color.Marron; break;
                case 5: res = (int)color.Blanc; break;
                case 6: res = (int)color.Blanc; break;
                case 7: res = (int)color.Gris; break;
                case 8: res = (int)color.Rose; break;
                case 9: res = (int)color.Blanc; break;
                case 10: res = (int)color.Marron; break;
                case 11: res = (int)color.Vert; break;
                case 12: res = (int)color.Blanc; break;
                case 13: res = (int)color.Argent; break;
                case 14: res = (int)color.Argent; break;
                case 15: res = (int)color.Gris; break;
                case 16: res = (int)color.Blanc; break;
                case 17: res = (int)color.Blanc; break;
                case 18: res = (int)color.Vert; break;
                case 19: res = (int)color.Blanc; break;
                case 20: res = (int)color.Blanc; break;

                default:
                    break;
            }

            return res;


        }
    }
}
