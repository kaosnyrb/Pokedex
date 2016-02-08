using System.Collections.Generic;

namespace Pokedex.Models.Generation
{
    public class Generation
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<object> abilities { get; set; }
        public MainRegion main_region { get; set; }
        public List<Move> moves { get; set; }
        public List<Name> names { get; set; }
        public List<PokemonSpecies> pokemon_species { get; set; }
        public List<Type> types { get; set; }
        public List<VersionGroup> version_groups { get; set; }
    }

    public class MainRegion
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Move
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Language
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Name
    {
        public string name { get; set; }
        public Language language { get; set; }
    }

    public class PokemonSpecies
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Type
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionGroup
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}