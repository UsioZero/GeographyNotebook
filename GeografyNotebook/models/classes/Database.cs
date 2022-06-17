using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GeografyNotebook.models.classes
{
    public class Database
    {   
        private static string citiesPath = @"C:\Users\Oleg\Documents\projects\c#\Курса4\GeographyNotebook\GeografyNotebook\assets\cities1.txt";
        private static string countriesPath = @"C:\Users\Oleg\Documents\projects\c#\Курса4\GeographyNotebook\GeografyNotebook\assets\countries1.txt";
        private static string regionsPath = @"C:\Users\Oleg\Documents\projects\c#\Курса4\GeographyNotebook\GeografyNotebook\assets\regions1.txt";
        private static string continentsPath = @"C:\Users\Oleg\Documents\projects\c#\Курса4\GeographyNotebook\GeografyNotebook\assets\continents1.txt";

        private List<City> cities;
        private List<Region> regions; 
        private List<Country> countries; 
        private List<Continent> continents; 

        private void GetCities()
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

        private void UpdateCitiesFile()
        {
            using (StreamWriter writer = new StreamWriter(citiesPath))
            {
                foreach(City city in cities)
                {
                    writer.WriteLine(city.ToString());
                }
            }
        }

        private void GetCountries()
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

        private void UpdateCountriesFile()
        {
            using (StreamWriter writer = new StreamWriter(countriesPath))
            {
                foreach(Country country in countries)
                {
                    writer.WriteLine(country.ToString());
                }
            }
        }

        private void GetRegions()
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
                        country: countries.Find(country => country.Uuid == Guid.Parse(words[3])),
                        population: Int32.Parse(words[4])
                    );

                    regions.Add(region);
                }
            }
        }

        private void UpdateRegionsFile()
        {
            using (StreamWriter writer = new StreamWriter(regionsPath))
            {
                foreach(Region region in regions)
                {
                    writer.WriteLine(region.ToString());
                }
            }
        }

        private void GetContinents()
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
                        countries: countries.FindAll(country => Array.Exists(countryIds, country.Uuid.ToString()))
                    );

                    continents.Add(continent);
                }
            }
        }

        private void UpdateContinentsFile()
        {
            using (StreamWriter writer = new StreamWriter(continentsPath))
            {
                foreach(Continent continent in continents)
                {
                    writer.WriteLine(continent.ToString());
                }
            }
        }

        public Database() {
            GetCities();
            GetCountries();
            GetRegions();
            GetContinents();
        }

        //public List<City> FindCities(string? searchFild, string? searchValue, string? orderByField)
        //{
        //    List<City> result = cities;
        //    if (searchFild != null && searchValue != null) {
        //        result = result.FindAll(predicate);
        //    }

        //    if (orderByField != null) {
        //        result = result.OrderBy(predicate);
        //    }
        //}

        public void AddCity(City newCity) {

        }

        public void UpdateCity(Guid uuid, City updated) {
            int index = cities.FindIndex(city => city.Uuid == uuid);

            cities[index] = updated;
            UpdateCitiesFile();
        }
    }
}