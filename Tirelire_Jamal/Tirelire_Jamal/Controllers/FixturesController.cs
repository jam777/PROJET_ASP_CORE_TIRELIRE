using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tirelire_Jamal.Data;
using Tirelire_Jamal.Models;
using System.IO;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.IdentityModel.Tokens;

namespace Tirelire_Jamal.Controllers
{
    public class FixturesController : Controller
    {


        [Route("Fixtures")]
        public IActionResult Index(Tirelire_JamContext ctx)
        {
            int NombreClient = 5;
            int NombreFabricant = 3;
            int Ref = 256874;
            var rand = new Random();

            string Dir = Directory.GetCurrentDirectory() + "\\wwwroot\\images";

            HashSet<string> couleur = new HashSet<string>();

            var imageFiles = Directory.GetFiles(Dir);
            for (int i = 0; i < imageFiles.Length; i++)
            {
                imageFiles[i] = Path.GetFileName(imageFiles[i]);
                /*int pos = imageFiles[i].IndexOf("_") + 1;
                var col = imageFiles[i].Substring(pos);
                pos = col.IndexOf(".");
                col = col.Substring(0, pos);*/
                couleur.Add(Help.file_color(imageFiles[i]));

            }

            /* var img = "";
             var idColor = 0;

             for (int i = 0; i < imageFiles.Length; i++)
             {
                 img = "/Images/" + imageFiles[0];
                 idColor = Help.image_idcolor(couleur, imageFiles[i]);
             }*/


            //Remove table
            Help.removeTable<Produit>(ctx.Produit);
            Help.removeTable<Fabricant>(ctx.Fabricant);
            Help.removeTable<Couleur>(ctx.Couleur);
            Help.removeTable<Adresse>(ctx.Adresse);

            ctx.SaveChanges();

            //Fixtures Adresse
            for (int i = 1; i <= NombreClient; i++)
            {
                ctx.Adresse.Add(
                     new Adresse
                     {
                         Id = i,
                         AdLivraison = Faker.Address.StreetAddress(),
                         AdFacturation = Faker.Address.StreetAddress(),
                     }
                );
            }

            //Fixtures des produits
            for (int i = 1; i <= imageFiles.Length; i++)
            {
                ctx.Produit.Add(
                    new Produit
                    {
                        Id = i,
                        Hauteur = rand.Next(15, 30),
                        Largeur = rand.Next(15, 30),
                        Longueur = rand.Next(15, 30),
                        Poids = rand.Next(1, 5),
                        Capacite = rand.Next(30, 100),
                        Description = Faker.Lorem.Paragraph(5),
                        Prix = rand.Next(5, 30),
                        Image = "/Images/" + imageFiles[i - 1],
                        Frais = 1.5,
                        Disponible = true,
                        Idfabricant = rand.Next(1, NombreFabricant + 1),
                        Idcouleur = Help.image_idcolor(couleur, imageFiles[i - 1]),
                        Reference = Ref + i,
                        Nom = "Tirelire" + i
                    }
                );
            }

            //Fixtures des Fabricants
            for (int i = 1; i <= NombreFabricant; i++)
            {
                ctx.Fabricant.Add(
                    new Fabricant
                    {
                        Id = i,
                        Nom = Faker.Company.Name()
                    }
                );
            }

            //Fixtures des Couleurs
            int k = 1;
            foreach (var col in couleur)
            {
                ctx.Couleur.Add(
                    new Couleur
                    {
                        Id = k,
                        Nom = col
                    }
                );
                k++;
            }

            ctx.SaveChanges();
            return Content("Fixtures terminées");
        }
    }
}
