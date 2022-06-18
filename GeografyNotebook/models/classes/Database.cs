using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GeografyNotebook.models.classes
{
    public class Database
    {   
        private static string citiesPath = @"..\..\assets\cities1.txt";
        private static string countriesPath = @"..\..\assets\countries1.txt";
        private static string regionsPath = @"..\..\assets\regions1.txt";
        private static string continentsPath = @"..\..\assets\continents1.txt";

        public List<City> cities { private set; get; }
        public List<Region> regions { private set; get; }
        public List<Country> countries { private set; get; }
        public List<Continent> continents { private set; get; }

        private void GetCitiesFromFile()
        {
            cities = new List<City>();

            using (StreamReader reader = new StreamReader(citiesPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    cities.Add(new City(line));
                }
            }
        }

        public void SaveCitiesToFile(List<City> updatedCities, string path)    
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach(City city in updatedCities)
                {
                    writer.WriteLine(city.ToString());
                }
            }
        }

        private void GetCountriesFromFile()
        {
            countries = new List<Country>();

            using (StreamReader reader = new StreamReader(countriesPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(';');

                    Country country = new Country(
                        uuid: new Guid(words[0]),
                        name: words[1],
                        area: Int32.Parse(words[2]),
                        population: Int32.Parse(words[3]),
                        governmentType: words[4],
                        capital: cities.Find(item => item.Uuid == Guid.Parse(words[5]))
                    );

                    countries.Add(country);
                }
            }
        }

        private void SaveCountriesToFile(List<Country> updatedCountries, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach(Country country in updatedCountries)
                {
                    writer.WriteLine(country.ToString());
                }
            }
        }

        private void GetRegionsFromFile()
        {
            regions = new List<Region>();

            using (StreamReader reader = new StreamReader(regionsPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(';');

                    Region region = new Region(
                        uuid: Guid.Parse(words[0]),
                        name: words[1],
                        type: words[2],
                        country: countries.Find(country => country.Uuid.ToString() == words[3]),
                        population: Int32.Parse(words[4])
                    );

                    regions.Add(region);
                }
            }
        }

        private void SaveRegionsToFile(List<Region> updatedRegions, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach(Region region in updatedRegions)
                {
                    writer.WriteLine(region.ToString());
                }
            }
        }

        private void GetContinentsFromFile()
        {
            continents = new List<Continent>();

            using (StreamReader reader = new StreamReader(continentsPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(';');
                    
                    string[] countryIds = words
                        .Skip(4)
                        .Take(words.Length - 5)
                        .ToArray();

                    Continent continent = new Continent(
                        uuid: Guid.Parse(words[0]),
                        name: words[1],
                        countries: countries.FindAll(country => Array.Exists(countryIds, item => item == country.Uuid.ToString()))
                    );

                    continents.Add(continent);
                }
            }
        }

        private void SaveContinentsToFile(List<Continent> updatedContinents, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach(Continent continent in updatedContinents)
                {
                    writer.WriteLine(continent.ToString());
                }
            }
        }

        public List<City> GetCities(
            string? searchField = null,
            string? searchValue = null,
            string orderByField = "Name")
        {
            List<City> result = cities.FindAll(city =>
                searchField != null && searchValue != null
                    ? city
                        .GetType()
                        .GetProperty(searchField)
                        .GetValue(city)
                        .ToString()
                        .Contains(searchValue)
                    : true);

                
            switch (orderByField) {
                case "CountryName":
                    return result.OrderBy(city => city.CountryName).ToList();
                case "Population":
                    return result.OrderBy(city => -city.Population).ToList();
                case "Latitude":
                    return result.OrderBy(city => city.Latitude).ToList();
                case "Longitude":
                    return result.OrderBy(city => city.Longitude).ToList();                        
                default:
                    return result.OrderBy(city => city.Name).ToList();
            }    
                
        }

        public List<Region> GetRegions(
            string? searchField = null,
            string? searchValue = null,
            string orderByField = "Name")
        {
            List<Region> result;

            switch (searchField)
            {
                case "Country":
                    result = regions.FindAll(region => region
                    .Country.Name.Contains(searchValue));
                    break;
                case "Population":
                    result = regions.FindAll(region => region
                    .Population == Convert.ToUInt32(searchValue));
                    break;
                case "Type":
                    result = regions.FindAll(region => region
                    .Type.Contains(searchValue));
                    break;
                case "Name":
                    result = regions.FindAll(region => region
                    .Name.Contains(searchValue));
                    break;
                default:
                    result = regions;
                    break;
            }

            switch (orderByField) {
                case "CountryName":
                    return result.OrderBy(region => region.Country.Name).ToList();
                case "Population":
                    return result.OrderBy(region => -region.Population).ToList();
                case "Type":
                    return result.OrderBy(region => region.Type).ToList();                   
                default:
                    return result.OrderBy(region => region.Name).ToList();
            }
        }

        public List<Country> GetCountries(
            string? searchField = null,
            string? searchValue = null,
            string orderByField = "Name")
        {
            switch (orderByField)
            {
                case "Area":
                    return countries.OrderBy(region => -region.Area).ToList();
                case "Population":
                    return countries.OrderBy(region => -region.Population).ToList();
                case "Government type":
                    return countries.OrderBy(region => region.GovernmentType).ToList();
                default:
                    return countries.OrderBy(region => region.Name).ToList();
            }
        }

        public void AddCity(City newCity) 
        {
            cities.Add(newCity);

            using (StreamWriter writer = new StreamWriter(citiesPath, append: true))
            {
                writer.WriteLine(newCity.ToString());
            }
        }

        public void UpdateCity(City updated) {
            int index = cities.FindIndex(city => city.Uuid == updated.Uuid);

            cities[index] = updated;
            SaveCitiesToFile(cities, citiesPath);
        }

        public Database()
        {
            GetCitiesFromFile();
            GetCountriesFromFile();
            GetRegionsFromFile();
            GetContinentsFromFile();
        }
    }
}