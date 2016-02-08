using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pokedex.Controllers
{
    public class GenerationController : Controller
    {
        public ActionResult Index(string Id)
        {
            var Generation = PokeapiService.GetGeneration(Id);
            Generation.pokemon_species.Sort((species, pokemonSpecies) => String.CompareOrdinal(species.name, pokemonSpecies.name));
            return View(Generation);
        }

    }
}
