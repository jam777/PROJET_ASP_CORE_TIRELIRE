using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Tirelire_Jamal.Data;
using Tirelire_Jamal.Models;
using Tirelire_Jamal.Repository;
using Tirelire_Jamal.Session;
using Tirelire_Jamal.ViewModels;

namespace Tirelire_Jamal.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private ISessionTirelire _session;
        private PanierSessionViewModel _panierSession;
        private readonly SignInManager<Client> _signInManager;
        private readonly UserManager<Client> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private IRepository<Adresse> _repoAd;

        public AccountController(ISessionTirelire session, SignInManager<Client> signInManager,
            IRepository<Adresse> repoAd, UserManager<Client> userManager, RoleManager<IdentityRole> roleManager)
        {
            _session = session;
            _panierSession = _session.deserialise();
            _signInManager = signInManager;
            _repoAd = repoAd;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Login()
        {

            ViewBag.totalPanier = _session.totalPanier();
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                /* var userName = _userManager.FindByEmailAsync(model.Email).Result.UserName;*/
                var user = _userManager.FindByEmailAsync(model.Email).Result;

                /*var check=_signInManager.UserManager.CheckPasswordAsync(user, model.Password);*/

                await _signInManager.SignOutAsync();

                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email ou Mot de Passe Invalide");
                }
            }
            ViewBag.totalPanier = _session.totalPanier();
            return View();
        }

        public IActionResult Register()
        {
            ViewBag.totalPanier = _session.totalPanier();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerModel)
        {
            registerModel.RoleName = "Client";

            if (ModelState.IsValid)
            {


                Adresse adresse = new Adresse()
                {
                    AdFacturation = registerModel.AdresseFacturation,
                    AdLivraison = registerModel.AdresseLivraison
                };
                _repoAd.Create(adresse);


                var IdAdresseRegister = _repoAd.FindAll().Where(p => p.AdFacturation == registerModel.AdresseFacturation).Select(p => p.Id).FirstOrDefault();

                Client clientUser = new Client()
                {

                    UserName = registerModel.UserName,
                    Nom = registerModel.Nom,
                    Prenom = registerModel.Prenom,
                    DateNaissance = registerModel.DateNaissance,
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

                    var resultSignIn = await _signInManager.PasswordSignInAsync(registerModel.UserName, registerModel.Password, false, false);
                    if (resultSignIn.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    _repoAd.Remove(_repoAd.FindOne(IdAdresseRegister));

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }


            ViewBag.totalPanier = _session.totalPanier();
            ViewBag.modelState = ModelState;
            return View();
        }


        public IActionResult Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                _signInManager.SignOutAsync();
            }
            return RedirectToAction("Index", "Home");
        }




    }

}
