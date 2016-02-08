using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pokedex.Models;

namespace Pokedex.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(PokeapiService.GetGenerationList());
        }
    }
}
