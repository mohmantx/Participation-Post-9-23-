using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _P__PokeApi
{
    class Pokemon
    {
        [JsonProperty("Results")]
        public List<AllResults> pkmnlist { get; set; }

        public Stats statt { get; set; }

        public List<Stats> statlist { get; set; }
    }
    public class AllResults
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return "" + name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1);
        }

    }

    public class Stats
    {
        public int height { get; set; }
        public int weight { get; set; }
    }

    //public class sprite
    //{

    //}
}
