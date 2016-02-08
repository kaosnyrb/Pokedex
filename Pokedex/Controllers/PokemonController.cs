using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pokedex.Controllers
{
    public class PokemonController : Controller
    {
        public ActionResult Index(string Id)
        {
            return View(PokeapiService.GetPokemon(Id));
        }
    }
}
