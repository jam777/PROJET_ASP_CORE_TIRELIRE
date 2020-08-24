using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tirelire_Jamal.Data;
using Tirelire_Jamal.Models;
using Tirelire_Jamal.Repository;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tirelire_Jamal.Services;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Threading;

namespace Tirelire_Jamal.Controllers
{
    public class PanierController : Controller
    {

        private IRepository<Produit> _repo;

        public PanierController(IRepository<Produit> repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Ajouter un produit dans le panier
        /// </summary>
        /// <param name="id">id du produit</param>
        /// <returns>Redirection vers Accueil</returns>
        [HttpPost]
        public IActionResult Ajouter(int id)
        {
            var session = HttpContext.Session;

            //Récupère la quantité
            int quantite = Int32.Parse(Request.Form["quantite"]);

            //Récupérer le produit
            var prod = _repo.FindOne(id);

            //Panier Vide
            if (session.GetString("Panier") == null)
            {
                //Date
                Commande cmd = new Commande { Date = DateTime.Now.ToString("d") };

                //Detail Commande
                cmd.DetailCommande.Add(
                   new DetailCommande
                   {
                       Quantite = quantite,
                       Prix = prod.Prix,
                       Idproduit = prod.Id,
                   }
                );

                //PanierSession : Cmd+QuantiteAjoute
                int quantiteTotal = 0;
                foreach (var detail in cmd.DetailCommande)
                {
                    quantiteTotal += detail.Quantite;
                }
                PanierSession panierSession = new PanierSession
                {
                    Cmd = cmd,
                    QuantiteAjoute = quantiteTotal
                };

                //Serialisation
                string jsonPanier = JsonSerializer.Serialize(
                    panierSession
                );

                //Creation session
                session.SetString("Panier", jsonPanier);
            }
            //Panier Remplit
            else
            {
                //Deserialiser : pannierSession
                PanierSession panierSession = JsonSerializer.Deserialize<PanierSession>(session.GetString("Panier"));

                //Panier Identique

                DetailCommande detail = panierSession.Cmd.DetailCommande.Where(p => p.Idproduit == id).FirstOrDefault();

                if (detail != null)
                {
                    detail.Quantite = quantite;
                    int quantiteTotal1 = 0;
                    foreach (var detail1 in panierSession.Cmd.DetailCommande)
                    {
                        quantiteTotal1 += detail1.Quantite;
                    }
                    panierSession.QuantiteAjoute = quantiteTotal1;
                }
                else
                {
                    panierSession.Cmd.DetailCommande.Add(
                          new DetailCommande
                          {
                              Quantite = quantite,
                              Prix = prod.Prix,
                              Idproduit = prod.Id
                          }
                      );
                    int quantiteTotal2 = 0;
                    foreach (var detail2 in panierSession.Cmd.DetailCommande)
                    {
                        quantiteTotal2 += detail2.Quantite;
                    }
                    panierSession.QuantiteAjoute = quantiteTotal2;
                }
                panierSession.Cmd.Date = DateTime.Now.ToString("d");

                //Serialiser
                string jsonPanier2 = JsonSerializer.Serialize(
                    panierSession
                );
                session.SetString("Panier", jsonPanier2);
            }
            TempData["statusAjoutPanier"] = 1;
            return RedirectToAction("Detail", "Home", new { id = prod.Id });
        }

        /// <summary>
        /// Supprimer un article du panier
        /// </summary>
        /// <param name="id">Id du produit</param>
        /// <returns></returns>
        public IActionResult Supprimer(int id)
        {
            var session = HttpContext.Session;

            //Panier Remplit
            if (session.GetString("Panier") != null)
            {
                PanierSession panierSession = deserialise();

                int nbDetail = panierSession.Cmd.DetailCommande.Count;

                //Panier avec un produit
                if (nbDetail == 1)
                {
                    HttpContext.Session.Clear();
                }
                //Panier avec plusieurs produits
                else if (nbDetail > 1)
                {
                    //Recherche du detail dans la collection  DetailCommande qui correspond a IdProduit
                    var detail = panierSession.Cmd.DetailCommande.Where(d => d.Idproduit == id).FirstOrDefault();

                    //Diminuons la quantitePanier
                    panierSession.QuantiteAjoute -= detail.Quantite;

                    //Suppression du detail
                    panierSession.Cmd.DetailCommande.Remove(detail);

                    //Serialisation et MAJ session
                    string jsonPanier = JsonSerializer.Serialize(
                    panierSession
                    );
                    session.SetString("Panier", jsonPanier);
                }
            }
            /* return Content("bonjour id :" + id);*/

            return RedirectToAction("DetailPanier", "Panier");
        }

        /// <summary>
        /// Affiche le detail d'une commande
        /// </summary>
        /// <returns>Vue avec PannierSession</returns>
        public IActionResult DetailPanier()
        {
            PanierSession panierSession = deserialise();
            ViewBag.totalPanier = totalPanier();
            if (panierSession != null)
            {
                ViewBag.Titre = "Commande : " + panierSession.Cmd.Date.ToString();
                ViewBag.prods = _repo.FindAll().ToList();
            }
            else
            {
                ViewBag.Titre = "Détail Panier";
            }

            return View(panierSession);
        }

        /// <summary>
        /// Permet de déserialiser une session
        /// </summary>
        /// <returns>PanierSeesion ou null</returns>
        private PanierSession deserialise()
        {
            if (HttpContext.Session.GetString("Panier") != null)
            {
                return JsonSerializer.Deserialize<PanierSession>(HttpContext.Session.GetString("Panier"));
            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// Afficher le nombre total de produits dans le panier
        /// </summary>
        /// <returns>int ou 0</returns>
        private int totalPanier()
        {
            if (deserialise() != null)
            {
                return deserialise().QuantiteAjoute;
            }
            else
            {
                return 0;
            }
        }
    }
}
