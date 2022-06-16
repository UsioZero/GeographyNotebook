using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografyNotebook.models.classes
{
    public class Country : GeographyUnit
    {
        public Country(Guid uuid, string name, int area, int population,
            string governmentType, City capital)
        {
            Uuid = uuid;
            Name = name;
            Area = area;
            Population = population;
            GovernmentType = governmentType;
            Capital = capital;
        }

        public int Area { set; get; }
        public string GovernmentType { set; get; }
        public City Capital { set; get; }


        public override string ToString()
        {
            return $"{Uuid};{Name};{Area};{Population};{GovernmentType};{Capital.Uuid}";
        }

        public override void edit()
        {
            throw new NotImplementedException();
        }
    }
}
