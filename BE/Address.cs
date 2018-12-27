using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Address
    {
        private string StreetName;
        private int AddressNumber;
        private string CityName;
        public Address(string _streetName, int _addressNumber, string _cityName)
        {
            StreetName = _streetName;
            AddressNumber = _addressNumber;
            CityName = _cityName;
        }
    }
}
