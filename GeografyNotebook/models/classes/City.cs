using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografyNotebook.models.classes
{
    public class City : GeographyUnit
    {
        public City (Guid uuid, string name, string countryName, double latitude,
            double longitude, int population)
        {
            Uuid = uuid;
            this.Name = name;
            this.CountryName = countryName;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Population = population;
        }

        public string CountryName { set; get; }
        public double Latitude { set; get; }
        public double Longitude { set; get; }

        public override string ToString()
        {
            return $"{Uuid};{Name};{CountryName};{Latitude};{Longitude};{Population}";
        }

        public override void edit()
        {
            throw new NotImplementedException();
        }
    }
}
