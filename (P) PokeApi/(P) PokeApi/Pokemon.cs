using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__PokeApi
{
    class Pokemon
    {
        public List<Results> pkmnlist { get; set; }

        public class Results
        {
            public string name { get; set; }
            public string URLlink { get; set; }

            public override string ToString()
            {
                return name;
            }

            public string CapitalizeFIrstLetter()
            {
                return "" + name[0].ToString().ToUpper() + name.Substring(1, name.Length - 2);
            }
        }

        public class Stats
        {
            public int weight { get; set; }
            public int height { get; set; }
        }

        public class Sprite
        {

        }
    }
}
