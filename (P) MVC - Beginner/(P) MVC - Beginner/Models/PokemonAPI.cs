using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _P__MVC___Beginner.Models
{
    
    public class Dex
    {
        [JsonProperty("Results")]
        public List<PokemonAPI> pkmnlist { get; set; }
    }
    public class PokemonAPI
    {
        public string name { get; set; }
        public string url { get; set; }
        public URL stats { get; set; }
    }
    public class URL
    {
        public int height { get; set; }
        public int weight { get; set; }
        public Sprite sprites { get; set; }
    }

    public class Sprite
    {
        public string front_default { get; set; }
        public string back_default { get; set; }
    }
}
