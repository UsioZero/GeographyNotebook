using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografyNotebook.models.classes
{
    public class City : GeografyUnit
    {
        public City (string name, string countryName, double latitude,
            double longitude, int population)
        {
            this.Name = name;
            this.CountryName = countryName;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Population = population;
        }

        public string Name { set; get; }
        public string CountryName { set; get; }
        public double Latitude { set; get; }
        public double Longitude { set; get; }
    }
}
