using System;

namespace GeografyNotebook.models.classes
{
    public class Region : GeographyUnit
    {
        public Region(Guid uuid, string name, string type,
            Country country, int population)
        {
            Uuid = uuid;
            Name = name;
            Type = type;
            Country = country;
            Capital = country.Capital;
            Population = population; 
        }

        public string Type { set; get; }
        public Country Country { set; get; }
        public City Capital { set; get; }


        public override string ToString()
        {
            return $"{Uuid};{Name};{Type};{Country.Uuid};{Population}";
        }
    }
}
