using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes_3
{
    public class Address
    {
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }

        public Address()
        {

        }
        public Address(int stnum, string stname, string city, string state, int zip)
        {
            stnum = StreetNumber;
            stname = StreetName;
            city = City;
            state = State;
            zip = Zip;
        }


    }
}
