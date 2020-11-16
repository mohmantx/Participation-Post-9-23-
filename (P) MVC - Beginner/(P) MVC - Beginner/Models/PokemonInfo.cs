using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _P__MVC___Beginner.Models
{
    public class PokemonInfo
    {
        public int height { get; set; }
        public int weight { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public Sprite sprites { get; set; }
        public All_Abilities abils { get; set; }
    }

    public class Sprite
    {
        public string front_default { get; set; }
        public string back_default { get; set; }
    }

    public class All_Abilities
    {
        public List<Ability> abilities { get; set; }
    }
    public class Ability
    {
        public string name { get; set; }
        public string url { get; set; }
        public bool is_hidden { get; set; }
    }
}
