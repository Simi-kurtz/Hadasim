using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNum { get; set; }

        public address(string city, string street, int houseNum)
        {
            City = city;
            Street = street;
            HouseNum = houseNum;
        }

        public address() {}
    }
}
