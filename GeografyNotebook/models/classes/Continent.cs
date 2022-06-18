using System;
using System.Collections.Generic;

namespace GeografyNotebook.models.classes
{
    public class Continent : GeographyUnit
    {
        public Continent(Guid uuid, string name, List<Country> countries)
        {
            Uuid = uuid;
            Name = name;
            Countries = countries;
            Population = 0;
            
            foreach(Country country in countries)
            {
                Population += country.Population;
            }
        }

        public List<Country> Countries { set; get; }

        public override string ToString()
        {
            string returnS = $"{Uuid};{Name};{Population};{Countries.Count}";

            foreach(Country country in Countries)
            {
                returnS += ";" + country.Uuid.ToString();
            }

            return returnS;
        }
    }
}
