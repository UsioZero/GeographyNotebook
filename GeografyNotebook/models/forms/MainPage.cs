using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class MainPage : Form
    {
        public List<classes.City> cities 
            = new List<classes.City> { };
        public List<classes.Region> regions 
            = new List<classes.Region> { };
        public List<classes.Country> countries 
            = new List<classes.Country> { };
        public List<classes.Continent> continents 
            = new List<classes.Continent> { };

        Random rand = new Random();

        public void extractCities()
        {
            //read cities data from database
            using (StreamReader reader = new StreamReader(path:
   @"C:\Users\Oleg\Documents\projects\c#\Курса4\" +
   @"GeografyNotebook\GeografyNotebook\assets\cities.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(';');
                    cities.Add(new classes.City(
                        uuid: Guid.NewGuid(),
                        name: words[0],
                        countryName: words[3],
                        latitude: Convert.ToDouble(words[1]),
                        longitude: Convert.ToDouble(words[2]),
                        population: Convert.ToInt32(words[5])
                        ));
                }
            }

            cities = cities.OrderBy(o => o.Name).ToList();
        }

        public void updateCities()
        {
            using (StreamWriter writer = new StreamWriter(path:
   @"C:\Users\Oleg\Documents\projects\c#\Курса4\" +
   @"GeografyNotebook\GeografyNotebook\assets\cities1.txt"))
            {
                foreach(classes.City city in cities)
                {
                    writer.WriteLine(city.ToString());
                }
            }
        }

        public void extractContinents()
        {
            //read continents data from database
            using (StreamReader reader = new StreamReader(path:
                @"C:\Users\Oleg\Documents\projects\c#\Курса4\" +
                @"GeografyNotebook\GeografyNotebook\assets\continents.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    bool isAdd = true;
                    string[] words = line.Split(';');
                    if (continents.FindIndex(
                        continent => continent.Name == words[0]) != -1)
                    {

                        classes.Country c = countries.Find(item => item.Name == words[1]);
                        if (countries.Find(item => item.Name == words[1]) == null)
                            isAdd = false;

                        if (isAdd)
                            continents[continents.FindIndex(continent =>
                            continent.Name == words[0])].Countries.Add(
                                c
                                );
                    }
                    else
                    {
                        classes.Country c = countries.Find(item => item.Name == words[1]);
                        if (countries.Find(item => item.Name == words[1]) == null)
                            isAdd = false;

                        if (isAdd)
                            continents.Add(new classes.Continent(
                                uuid: Guid.NewGuid(),
                                name: words[0],
                                countries: new List<classes.Country>
                                {
                                    c
                                }
                                ));
                    }

                }
            }

            continents = continents.OrderBy(o => o.Name).ToList();
        }

        public void writeContinents()
        {

        }

        public void extractRegions()
        {
            //read region data from database
            using (StreamReader reader = new StreamReader(path:
                @"C:\Users\Oleg\Documents\projects\c#\Курса4\" +
                @"GeografyNotebook\GeografyNotebook\assets\regions.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(';');
                    int indexof = countries.FindIndex(item => item.Name == words[1]);
                    classes.Country c;
                    if (words[2] == null || words[2].Length < 3)
                        words[2] = "none";

                    if (indexof != -1)
                    {
                        c = countries[indexof];
                    }
                    else
                    {
                        c = null;
                    }

                    if (indexof == -1 || c == null)
                    {
                        c = new classes.Country(
                            uuid: Guid.NewGuid(),
                            name: "0",
                            area: 0,
                            population: 0,
                            governmentType: "0",
                            capital: new classes.City(
                                uuid: Guid.NewGuid(),
                                name: "0",
                                countryName: "0",
                                latitude: 0,
                                longitude: 0,
                                population: 0
                                ));
                    }

                    regions.Add(new classes.Region(
                            uuid: Guid.NewGuid(),
                            name: words[0],
                            type: words[2],
                            country: c,
                            population: rand.Next(1000, 1000000)
                        ));

                }
            }

            regions = regions.OrderBy(o => o.Name).ToList();
        }

        public void writeRegions()
        {

        }

        public void extractCountries()
        {
            List<string> cnames = new List<string> { };
            List<classes.City> ccapitlas = new List<classes.City> { };
            List<Int32> carea = new List<Int32> { };
            List<string> cgovtype = new List<string> { };
            List<Int32> cpopulation = new List<Int32> { };

            //read Country data from database
            using (StreamReader reader = new StreamReader(path:
                @"C:\Users\Oleg\Documents\projects\c#\Курса4\" +
                @"GeografyNotebook\GeografyNotebook\assets\capitals.txt"))
            //names and capitals
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {

                    string[] words = line.Split(';');
                    cnames.Add(words[0]);
                    if (cities.Find(city => city.Name == words[1]) != null)
                        ccapitlas.Add(cities.Find(city => city.Name == words[1]));
                    else
                        ccapitlas.Add(cities[rand.Next(cities.Count)]);
                }
            }

            using (StreamReader reader = new StreamReader(path:
                @"C:\Users\Oleg\Documents\projects\c#\Курса4\" +
                @"GeografyNotebook\GeografyNotebook\assets\country_area.txt"))
            //area
            {
                string line;
                List<string> tmpnames = new List<string> { };
                List<Int32> tmparea = new List<Int32> { };


                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(';');
                    tmpnames.Add(words[1]);
                    if (Int32.TryParse(words[2], out _))
                        tmparea.Add(Convert.ToInt32(words[2]));
                    else
                        tmparea.Add(rand.Next(100, 10000));
                }

                for (int i = 0; i < cnames.Count; i++)
                {
                    bool isFind = false;
                    string tmpname = cnames[i];

                    for (int j = 0; j < tmpnames.Count; j++)
                    {
                        if (tmpname == tmpnames[j] && isFind == false)
                        {
                            isFind = true;
                            carea.Add(tmparea[j]);
                        }
                    }

                    //country not exist
                    if (isFind == false) carea.Add(rand.Next(100, 10000));
                }
            }

            using (StreamReader reader = new StreamReader(path:
               @"C:\Users\Oleg\Documents\projects\c#\Курса4\GeografyNotebook\" +
                @"GeografyNotebook\assets\country_gov_type.txt"))
            //govtype
            {
                string line;
                List<string> tmpnames = new List<string> { };
                List<string> tmpgovtype = new List<string> { };

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(';');
                    tmpnames.Add(words[0]);
                    tmpgovtype.Add(words[1]);
                }

                for (int i = 0; i < cnames.Count; i++)
                {
                    bool isFind = false;
                    string tmpname = cnames[i];

                    for (int j = 0; j < tmpnames.Count; j++)
                    {
                        if (tmpname == tmpnames[j] && isFind == false)
                        {
                            isFind = true;
                            if (tmpgovtype[j] != null && tmpgovtype[j].Length > 1)
                                cgovtype.Add(tmpgovtype[j]);
                            else
                                cgovtype.Add("none");
                        }
                    }

                    //country not exist
                    if (isFind == false) cgovtype.Add("none");
                }
            }

            using (StreamReader reader = new StreamReader(path:
               @"C:\Users\Oleg\Documents\projects\c#\Курса4\GeografyNotebook" +
                @"\GeografyNotebook\assets\country_population.txt"))
            //population
            {
                string line;
                List<string> tmpnames = new List<string> { };
                List<Int32> tmppop = new List<Int32> { };


                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(';');
                    tmpnames.Add(words[1]);
                    if (Int32.TryParse(words[2], out _))
                        tmppop.Add(Convert.ToInt32(words[2]));
                    else
                        tmppop.Add(rand.Next(1000, 1000000));
                }

                for (int i = 0; i < cnames.Count; i++)
                {
                    bool isFind = false;
                    string tmpname = cnames[i];

                    for (int j = 0; j < tmpnames.Count; j++)
                    {
                        if (tmpname == tmpnames[j] && isFind == false)
                        {
                            isFind = true;
                            cpopulation.Add(tmppop[j]);
                        }
                    }

                    //country not exist
                    if (isFind == false) cpopulation.Add(rand.Next(1000, 1000000));
                }
            }

            for (int i = 0; i < cnames.Count; i++)
            {
                countries.Add(new classes.Country(
                    uuid: Guid.NewGuid(),
                    name: cnames[i],
                    area: carea[i],
                    population: cpopulation[i],
                    governmentType: cgovtype[i],
                    capital: ccapitlas[i]
                    ));
            }

            countries = countries.OrderBy(o => o.Name).ToList();
        }

        public void writeCountries()
        {
            //        using (StreamWriter writer = new StreamWriter(path:
            //@"C:\Users\Oleg\Documents\projects\c#\Курса4\GeographyNotebook\GeografyNotebook\assets\counties.txt"))
            //        {
            //            for(int i = 0; i < countries.Count; i++)
            //            {

            //            }
            //        }
        }

        public MainPage()
        {
            InitializeComponent();

            extractCities();
            extractCountries();
            extractRegions();
            extractContinents();
        }

        private void onCityButtonClick(object sender, EventArgs e)
        {
            Form form = new CityPage(cities);
            form.Show();
            Hide();
        }

        private void onRegionButtonClick(object sender, EventArgs e)
        {
            Form form = new RegionPage(regions);
            form.Show();
            Hide();
        }

        private void onCountryButtonClick(object sender, EventArgs e)
        {
            Form form = new CountryPage(countries);
            form.Show();
            Hide();
        }

        private void onContinentButtonClick(object sender, EventArgs e)
        {
            Form form = new ContinentPage(continents);
            form.Show();
            Hide();
        }

        private void onBackButtonClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void CityButton_Click(object sender, EventArgs e)
            => onCityButtonClick(sender, e);

        private void RegionButton_Click(object sender, EventArgs e)
            => onRegionButtonClick(sender, e);

        private void CountryButton_Click(object sender, EventArgs e)
            => onCountryButtonClick(sender, e);

        private void ContinentButton_Click(object sender, EventArgs e)
            => onContinentButtonClick(sender, e);

        private void MainPage_KeyDown(object sender, KeyEventArgs e)
            => onBackButtonClick(sender, e);

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
