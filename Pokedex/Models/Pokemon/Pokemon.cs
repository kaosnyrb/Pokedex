using System.Collections.Generic;

namespace Pokedex.Models.Pokemon
{
    public class Ability2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Ability
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public Ability2 ability { get; set; }
    }

    public class Form
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class GameIndice
    {
        public int game_index { get; set; }
        public Version version { get; set; }
    }

    public class Item
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionDetail
    {
        public int rarity { get; set; }
        public Version2 version { get; set; }
    }

    public class HeldItem
    {
        public Item item { get; set; }
        public List<VersionDetail> version_details { get; set; }
    }

    public class LocationArea
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Method
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class EncounterDetail
    {
        public int min_level { get; set; }
        public int max_level { get; set; }
        public List<object> condition_values { get; set; }
        public int chance { get; set; }
        public Method method { get; set; }
    }

    public class Version3
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionDetail2
    {
        public int max_chance { get; set; }
        public List<EncounterDetail> encounter_details { get; set; }
        public Version3 version { get; set; }
    }

    public class LocationAreaEncounter
    {
        public LocationArea location_area { get; set; }
        public List<VersionDetail2> version_details { get; set; }
    }

    public class Move2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionGroup
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class MoveLearnMethod
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionGroupDetail
    {
        public int level_learned_at { get; set; }
        public VersionGroup version_group { get; set; }
        public MoveLearnMethod move_learn_method { get; set; }
    }

    public class Move
    {
        public Move2 move { get; set; }
        public List<VersionGroupDetail> version_group_details { get; set; }
    }

    public class Species
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Stat2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat2 stat { get; set; }
    }

    public class Type2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Type
    {
        public int slot { get; set; }
        public Type2 type { get; set; }
    }

    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public bool is_default { get; set; }
        public int order { get; set; }
        public int weight { get; set; }
        public List<Ability> abilities { get; set; }
        public List<Form> forms { get; set; }
        public List<GameIndice> game_indices { get; set; }
        public List<HeldItem> held_items { get; set; }
        public List<LocationAreaEncounter> location_area_encounters { get; set; }
        public List<Move> moves { get; set; }
        public Species species { get; set; }
        public List<Stat> stats { get; set; }
        public List<Type> types { get; set; }
    }
}