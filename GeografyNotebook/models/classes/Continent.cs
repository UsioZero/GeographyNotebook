using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override void edit()
        {
            throw new NotImplementedException();
        }
    }
}
