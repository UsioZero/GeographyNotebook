using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GeografyNotebook.models.classes
{
    public class Database
    {   
        private static readonly string citiesPath = @"..\..\assets\cities.txt";
        private static readonly string countriesPath = @"..\..\assets\countries.txt";
        private static readonly string regionsPath = @"..\..\assets\regions.txt";
        private static readonly string continentsPath 
            = @"..\..\assets\continents.txt";

        public Database()
        {
            GetCitiesFromFile();
            GetCountriesFromFile();
            GetRegionsFromFile();
            GetContinentsFromFile();
        }

        public List<City> Cities { private set; get; }
        public List<Region> Regions { private set; get; }
        public List<Country> Countries { private set; get; }
        public List<Continent> Continents { private set; get; }

        public List<City> GetCities(
            string? searchField = null,
            string? searchValue = null,
            string orderByField = "Name")
        {
            List<City> result = Cities.FindAll(city =>
                searchField != null && searchValue != null
                    ? city
                        .GetType()
                        .GetProperty(searchField)
                        .GetValue(city)
                        .ToString()
                        .Contains(searchValue)
                    : true);

            return orderByField switch
            {
                "CountryName" => result.OrderBy(city => city.CountryName)
                .ToList(),
                "Population" => result.OrderBy(city => -city.Population)
                .ToList(),
                "Latitude" => result.OrderBy(city => city.Latitude)
                .ToList(),
                "Longitude" => result.OrderBy(city => city.Longitude)
                .ToList(),
                _ => result.OrderBy(city => city.Name).ToList(),
            };
        }

        public List<Region> GetRegions(
            string? searchField = null,
            string? searchValue = null,
            string orderByField = "Name")
        {
            List<Region> result = searchField switch
            {
                "Country" => Regions.FindAll(region => region
                                    .Country.Name.Contains(searchValue)),
                "Population" => Regions.FindAll(region => region
                                    .Population == Convert
                                    .ToInt32(searchValue)),
                "Type" => Regions.FindAll(region => region
                                    .Type.Contains(searchValue)),
                "Name" => Regions.FindAll(region => region
                                    .Name.Contains(searchValue)),
                _ => Regions,
            };
            return orderByField switch
            {
                "CountryName" => result.OrderBy(region => region
                                    .Country.Name).ToList(),
                "Population" => result.OrderBy(region => -region
                                    .Population).ToList(),
                "Type" => result.OrderBy(region => region.Type).ToList(),
                _ => result.OrderBy(region => region.Name).ToList(),
            };
        }

        public List<Country> GetCountries(
            string? searchField = null,
            string? searchValue = null,
            string orderByField = "Name")
        {
            List<Country> result = searchField switch
            {
                "Area" => Countries.FindAll(region => region
                                    .Area == Convert.ToInt32(searchValue)),
                "Population" => Countries.FindAll(region => region
                                    .Population == Convert.ToInt32(searchValue)),
                "Government type" => Countries.FindAll(region => region
                                    .GovernmentType.Contains(searchValue)),
                "Name" => Countries.FindAll(region => region
                                    .Name.Contains(searchValue)),
                _ => Countries,
            };
            return orderByField switch
            {
                "Area" => result.OrderBy(region => -region.Area).ToList(),
                "Population" => result.OrderBy(region => -region
                                    .Population).ToList(),
                "Government type" => result.OrderBy(region => region
                                    .GovernmentType).ToList(),
                _ => result.OrderBy(region => region.Name).ToList(),
            };
        }

        public void AddCity(City newCity) 
        {
            Cities.Add(newCity);

            using StreamWriter writer
                = new StreamWriter(citiesPath, append: true);
            writer.WriteLine(newCity.ToString());
        }

        public void UpdateCity(City updated) {
            int index = Cities.FindIndex(city => city.Uuid == updated.Uuid);

            Cities[index] = updated;
            SaveCitiesToFile(Cities, citiesPath);
        }

        public void SaveCitiesToFile(List<City> updatedCities, string path)
        {
            using StreamWriter writer = new StreamWriter(path);
            foreach (City city in updatedCities)
            {
                writer.WriteLine(city.ToString());
            }
        }

        private void GetCitiesFromFile()
        {
            Cities = new List<City>();

            using StreamReader reader = new StreamReader(citiesPath);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Cities.Add(new City(line));
            }
        }
        private void GetRegionsFromFile()
        {
            Regions = new List<Region>();

            using StreamReader reader = new StreamReader(regionsPath);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(';');

                Region region = new Region(
                    uuid: Guid.Parse(words[0]),
                    name: words[1],
                    type: words[2],
                    country: Countries.Find(country => country
                    .Uuid.ToString() == words[3]),
                    population: Int32.Parse(words[4])
                );

                Regions.Add(region);
            }
        }

        private void GetCountriesFromFile()
        {
            Countries = new List<Country>();

            using StreamReader reader = new StreamReader(countriesPath);
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
                    capital: Cities.Find(item => item
                    .Uuid == Guid.Parse(words[5]))
                );

                Countries.Add(country);
            }
        }

        private void GetContinentsFromFile()
        {
            Continents = new List<Continent>();

            using StreamReader reader = new StreamReader(continentsPath);
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
                    countries: Countries.FindAll(country => Array
                    .Exists(countryIds, item => item == country
                    .Uuid.ToString()))
                );

                Continents.Add(continent);
            }
        }

        private void SaveCountriesToFile(List<Country> updatedCountries,
            string path)
        {
            using StreamWriter writer = new StreamWriter(path);
            foreach (Country country in updatedCountries)
            {
                writer.WriteLine(country.ToString());
            }
        }

        private void SaveRegionsToFile(List<Region> updatedRegions
            , string path)
        {
            using StreamWriter writer = new StreamWriter(path);
            foreach (Region region in updatedRegions)
            {
                writer.WriteLine(region.ToString());
            }
        }

        private void SaveContinentsToFile(List<Continent> updatedContinents
            , string path)
        {
            using StreamWriter writer = new StreamWriter(path);
            foreach (Continent continent in updatedContinents)
            {
                writer.WriteLine(continent.ToString());
            }
        }
    }
}