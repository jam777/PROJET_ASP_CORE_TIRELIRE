using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tirelire_Jamal.Data;
using Tirelire_Jamal.Services;

namespace Tirelire_Jamal.Controllers
{
    public class HomeController : Controller
    {
        private Tirelire_JamContext _ctx;

        public HomeController(Tirelire_JamContext context)
        {
            _ctx = context;
        }

        public IActionResult Index()
        {

            var prods = _ctx.Produit.ToList();

            ViewBag.Titre = "Liste des articles";

            return View(prods);
        }

        public IActionResult Detail(int id)
        {
            //Detail d'un article
            var prod = _ctx.Produit.Where(p => p.Id == id).FirstOrDefault();

            //Les articles de même couleur

            //On recupere la couleur de l'objet affiché
            var ColorDetail = prod.IdcouleurNavigation;
            var prodsColor = ColorDetail.Produit.Take(4).ToList();
            prodsColor.Remove(prod);

            //Passons 2 models a la vue
            var modelVue = new DetailColor()
            {
                produit = prod,
                colorProduit = prodsColor
            };

            ViewBag.Titre = "Detail d'un article";

            return View(modelVue);

        }

    }

}
