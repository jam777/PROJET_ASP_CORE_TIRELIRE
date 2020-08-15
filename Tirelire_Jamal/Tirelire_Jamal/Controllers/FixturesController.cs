using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
            string[] color = new string[] {
                "Blanc","Rose","Gris","Marron","Vert","Argent"
            };
            int NombreCouleur = color.Length;




            string r = "5_qsdfqsdfqsdf";
            int l = Int32.Parse(r[0].ToString());

            var rand = new Random();

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
            for (int i = 1; i <= 20; i++)
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
                        Description = Faker.Lorem.Sentences(5).ToString(),
                        Prix = rand.Next(5, 30),
                        Image = "/images/tirelire" + i + ".jpg",
                        Frais = 1.5,
                        Disponible = true,
                        Idfabricant = rand.Next(1, NombreFabricant + 1),
                        Idcouleur = Help.color_produit(i),
                        Reference = Ref + i
                    }
                );
            }

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

            for (int i = 0; i < NombreCouleur; i++)
            {
                ctx.Couleur.Add(
                    new Couleur
                    {
                        Id = i + 1,
                        Nom = color[i]
                    }
                );
            }

            ctx.SaveChanges();




            return Content("Fixtures terminées");
        }
    }
}
