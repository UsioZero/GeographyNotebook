using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografyNotebook.models.classes
{
    public class Country : GeografyUnit
    {
        public Country(string name, int area, int population,
            string governmentType, City capital)
        {
            this.Name = name;
            this.Area = area;
            this.Population = population;
            this.GovernmentType = governmentType;
            this.Capital = capital;

            //Population = 0;
            //foreach (Region r in Regions)
            //{
            //    Population += r.Population;
            //}
        }

        public string Name { set; get; }
        public int Area { set; get; }
        public string GovernmentType { set; get; }
        public City Capital { set; get; }

    }
}
