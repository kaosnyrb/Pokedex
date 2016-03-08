using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using Pokedex.Models;
using Pokedex.Models.Generation;
using Pokedex.Models.Pokemon;

namespace Pokedex
{
    public class PokeapiService
    {
        private static HttpClient Client = new HttpClient();

        public static List<GenerationLink> GetGenerationList()
        {
            var message = new HttpRequestMessage(HttpMethod.Get, "http://pokeapi.co/api/v2/generation/");
            var response = Client.SendAsync(message).Result;
            string jsonresponse = response.Content.ReadAsStringAsync().Result;
            Results results = JsonConvert.DeserializeObject<Results>(jsonresponse);

            List<GenerationLink> links = new List<GenerationLink>();
            foreach (var link in results.results)
            {
                links.Add(new GenerationLink(){name = link.name,url = link.url});
            }
            return links;
        }

        public static Generation GetGeneration(string id)
        {
            var message = new HttpRequestMessage(HttpMethod.Get, "http://pokeapi.co/api/v2/generation/" + id);
            var response = Client.SendAsync(message).Result;
            string jsonresponse = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Generation>(jsonresponse);
        }

        public static Pokemon GetPokemon(string id)
        {
            var message = new HttpRequestMessage(HttpMethod.Get, "http://pokeapi.co/api/v2/pokemon/" + id);
            var response = Client.SendAsync(message).Result;
            string jsonresponse = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Pokemon>(jsonresponse);
        }
    }
}