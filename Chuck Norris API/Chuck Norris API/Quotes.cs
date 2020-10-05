using System;
using System.Collections.Generic;
using System.Text;

namespace Chuck_Norris_API
{
    class Quotes
    {
        public List<Results> categorylist { get; set; }
    }

    public class Results
    {
        public string categories { get; set; }
    }
}
