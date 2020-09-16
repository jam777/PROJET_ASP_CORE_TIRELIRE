using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tirelire_Jamal.Data;
using Tirelire_Jamal.Repository;
using Tirelire_Jamal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Tirelire_Jamal.Session;
using Tirelire_Jamal.ViewModels;
using Tirelire_Jamal.Services;


namespace Tirelire_Jamal.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private IRepository<Produit> _repo;
        private ISessionTirelire _session;

        public HomeController(IRepository<Produit> repo,
            ISessionTirelire session,
            PaginatedList<Produit> pagination = null
            )
        {
            _repo = repo;
            _session = session;

        }

        /// <summary>
        /// Liste les articles
        /// </summary>
        /// <returns>Vue avec collection de produits</returns>

        public IActionResult Index(int? pageNumber)
        {
            //Récupère tous les produits
            var prods = _repo.FindAll().AsQueryable();

            //Pagination

            ViewBag.Titre = "Liste des articles";
            ViewBag.totalPanier = _session.totalPanier();

            int pageSize = 6;
            return View(PaginatedList<Produit>.Create(prods, pageNumber ?? 1, pageSize));


        }

        /// <summary>
        /// Detail d'un produit
        /// </summary>
        /// <param name="id">Id du produit</param>
        /// <returns>Vue avec DetailColor</returns>
        public IActionResult Detail(int id)
        {
            //Detail d'un article
            var prod = _repo.FindOne(id);

            //Les articles de même couleur

            var ColorDetail = prod.IdcouleurNavigation;
            var prodsColor = ColorDetail.Produit.Take(4).ToList();
            prodsColor.Remove(prod);

            //Passons 2 models a la vue
            var modelVue = new DetailColorViewModel()
            {
                produit = prod,
                colorProduit = prodsColor
            };

            ViewBag.Titre = "Detail d'un article";
            ViewBag.totalPanier = _session.totalPanier();
            ViewBag.quantitePanier = _session.quantitePanier(id);

            double[] infoPanierModal = {
                prod.Prix,
                _session.quantitePanier(id),
                ((prod.Frais*prod.Poids+prod.Prix)*_session.quantitePanier(id))
            };

            if (TempData["statusAjoutPanier"] != null)
            {
                ViewBag.statusAjoutPanier = TempData["statusAjoutPanier"];
            }
            else
            {
                ViewBag.statusAjoutPanier = 0;
            }
            ViewBag.infoPanierModal = infoPanierModal;
            return View(modelVue);
        }
    }

}
