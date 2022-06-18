using System;

namespace GeografyNotebook.models.classes
{
    public class City : GeographyUnit
    {
        public City (Guid uuid, string name, string countryName, double latitude,
            double longitude, int population)
        {
            Uuid = uuid;
            Name = name;
            CountryName = countryName;
            Latitude = latitude;
            Longitude = longitude;
            Population = population;
        }

        public City(string line)
        {
            string[] words = line.Split(';');
            Uuid = Guid.Parse(words[0]);
            Name = words[1];
            CountryName = words[2];
            Latitude = Double.Parse(words[3]);
            Longitude = Double.Parse(words[4]);
            Population = Int32.Parse(words[5]);
        }

        public string CountryName { protected set; get; }

        public double Latitude { protected set; get; }
        
        public double Longitude { protected set; get; }

        public override string ToString()
        {
            return $"{Uuid};{Name};{CountryName};{Latitude};{Longitude};{Population}";
        }
    }
}
