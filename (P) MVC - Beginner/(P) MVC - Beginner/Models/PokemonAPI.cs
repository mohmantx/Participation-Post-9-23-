using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _P__MVC___Beginner.Models
{
    
    public class Result
    {
        public string name { get; set; }
        public string url { get; set; }
    }
    public class PokemonAPI
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<Result> results { get; set; }
    }
 
}
