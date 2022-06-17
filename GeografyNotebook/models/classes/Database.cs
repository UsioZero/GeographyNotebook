using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GeografyNotebook.models.classes
{
    public class Database
    {   
        private static string citiesPath 
            = @"C:\Users\Oleg\Documents\projects\c#\Курса4\GeographyNotebook\GeografyNotebook\assets\cities1.txt";
        private static string countriesPath 
            = @"C:\Users\Oleg\Documents\projects\c#\Курса4\GeographyNotebook\GeografyNotebook\assets\countries1.txt";
        private static string regionsPath 
            = @"C:\Users\Oleg\Documents\projects\c#\Курса4\GeographyNotebook\GeografyNotebook\assets\regions1.txt";
        private static string continentsPath 
            = @"C:\Users\Oleg\Documents\projects\c#\Курса4\GeographyNotebook\GeografyNotebook\assets\continents1.txt";
        private static string searchResultPath
            = @"C:\Users\Oleg\Documents\projects\c#\Курса4\GeographyNotebook\GeografyNotebook\assets\search_results.txt";

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

        private void SaveCitiesToFile(List<City> updatedCities, string path)    
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

        public List<City> ChangeCities(string searchFild, string searchValue)
        {
            List<City> result = cities;

            result = result.FindAll(city => city
                .GetType()
                .GetProperty(searchFild)
                .GetValue(city)
                .ToString() == searchValue);

            return result;
        }

        public List<City> ChangeCities(string orderByField)
        {
            List<City> result = cities;

            result = result.OrderBy(city => city
                .GetType()
                .GetProperty(orderByField)
                .GetValue(city)
                .ToString()).ToList();

            return result;
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