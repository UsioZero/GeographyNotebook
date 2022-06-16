using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografyNotebook.models.classes
{
    public class Continent : GeografyUnit
    {
        public Continent(string name, List<Country> countries)
        {
            this.Name = name;
            this.Countries = countries;
            this.Population = 0;
            foreach(Country country in countries)
            {
                this.Population += country.Population;
            }
        }

        public string Name { set; get; }
        public List<Country> Countries { set; get; }
    }
}
