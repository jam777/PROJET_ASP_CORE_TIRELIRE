using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tirelire_Jamal.Controllers
{
    public class TestController : Controller
    {

        public IActionResult Index()
        {

            if (HttpContext.Request.HasFormContentType)
            {
                string r = Request.Form["txt"];
                return Content("Requete : " + r);
            }
            else
            {
                return View();
            }

            /*String.IsNullOrEmpty(Request.Query["name"]);*/


        }
    }
}
