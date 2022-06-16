using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografyNotebook.models.classes
{
    public class Region : GeografyUnit
    {
        public Region(string name, string type,
            Country country, int population)
        {
            this.Name = name;
            this.Type = type;
            this.Country = country;
            this.Capital = country.Capital;
            this.Population = population; 
        }

        public string Name { set; get; }
        public string Type { set; get; }
        public Country Country { set; get; }
        public City Capital { set; get; }
    }
}
