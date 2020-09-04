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
using Tirelire_Jamal.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Tirelire_Jamal.Controllers
{
    public class FixturesController : Controller
    {
        private Tirelire_JamContext _ctx;
        private readonly UserManager<Client> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public FixturesController(Tirelire_JamContext ctx, UserManager<Client> userManager = null, RoleManager<IdentityRole> roleManager = null)
        {
            _ctx = ctx;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [Route("Fixtures")]
        public async Task<IActionResult> Index()
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
                couleur.Add(Help.file_color(imageFiles[i]));

            }

            _ctx.Database.EnsureDeleted();
            _ctx.Database.EnsureCreated();

            //Fixtures Adresse
            for (int i = 1; i <= NombreClient; i++)
            {
                _ctx.Adresse.Add(
                     new Adresse
                     {
                         AdLivraison = Faker.Address.StreetAddress(),
                         AdFacturation = Faker.Address.StreetAddress(),
                     }
                );
            }
            _ctx.SaveChanges();

            List<int> IdsAdresse = new List<int>();

            foreach (var model in _ctx.Adresse)
            {
                IdsAdresse.Add(model.Id);
            }
            var IdAd = IdsAdresse.ToArray();

            //Fixtures des Fabricants
            for (int i = 1; i <= NombreFabricant; i++)
            {
                _ctx.Fabricant.Add(
                    new Fabricant
                    {
                        Nom = Faker.Company.Name()
                    }
                );
            }
            _ctx.SaveChanges();

            List<int> IdsFabriquant = new List<int>();

            foreach (var model in _ctx.Fabricant)
            {
                IdsFabriquant.Add(model.Id);
            }
            var IdFab = IdsFabriquant.ToArray();

            //Fixtures des Couleurs

            foreach (var col in couleur)
            {
                _ctx.Couleur.Add(
                    new Couleur
                    {
                        Nom = col
                    }
                );
            }
            _ctx.SaveChanges();

            //Fixtures des produits
            for (int i = 1; i <= imageFiles.Length; i++)
            {
                string ImgColor = Help.file_color(imageFiles[i - 1]);

                int idcolor = _ctx.Couleur.Where(p => p.Nom == ImgColor).FirstOrDefault().Id;

                _ctx.Produit.Add(
                    new Produit
                    {

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
                        Idfabricant = rand.Next(IdFab[0], IdFab[IdFab.Length - 1] + 1),
                        Idcouleur = idcolor,
                        Reference = Ref + i,
                        Nom = "Tirelire" + i
                    }
                );
            }

            _ctx.SaveChanges();

            //Enregistrer un client par defaut

            RegisterViewModel registerModel = new RegisterViewModel()
            {
                RoleName = "Client",
                AdresseFacturation = "Adresse1",
                AdresseLivraison = "Adresse2",
                UserName = "sponge",
                Password = "Bob777%L",
                Nom = "Eponge",
                Prenom = "Bob",
                DateNaissance = new DateTime(1978, 05, 01),
                Telephone = "01-02-03-04-05",
                Genre = true,
                Email = "bob@bob",
            };
            Adresse adresse = new Adresse()
            {
                AdFacturation = registerModel.AdresseFacturation,
                AdLivraison = registerModel.AdresseLivraison
            };
            _ctx.Adresse.Add(adresse);
            _ctx.SaveChanges();

            var IdAdresseRegister = _ctx.Adresse.Where(p => p.AdFacturation == registerModel.AdresseFacturation).Select(p => p.Id).FirstOrDefault();


            Client clientUser = new Client()
            {

                /*UserName = registerModel.UserName,
                Nom = registerModel.Nom,
                Prenom = registerModel.Prenom,
                DateNaissance = registerModel.DateNaissance,*/
                Telephone = registerModel.Telephone,
                Genre = registerModel.Genre,
                Idadresse = IdAdresseRegister,
                Email = registerModel.Email,
                Active = true
            };

            var result = await _userManager.CreateAsync(clientUser, registerModel.Password);

            if (result.Succeeded)
            {

                bool roleExists = await _roleManager.RoleExistsAsync(registerModel.RoleName);
                if (!roleExists)
                {
                    await _roleManager.CreateAsync(new IdentityRole(registerModel.RoleName));
                }

                if (!await _userManager.IsInRoleAsync(clientUser, registerModel.RoleName))
                {
                    await _userManager.AddToRoleAsync(clientUser, registerModel.RoleName);
                }

                if (!string.IsNullOrWhiteSpace(clientUser.Email))
                {
                    Claim claim = new Claim(ClaimTypes.Email, clientUser.Email);
                    await _userManager.AddClaimAsync(clientUser, claim);
                }


            }



            return Content("Fixtures terminées");
        }
    }
}
