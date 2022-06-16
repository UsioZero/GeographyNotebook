using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class CityPage : Form
    {
        List<classes.City> cities;
        List<classes.City> searchCities = new List<classes.City> { };
        int curFirstCity = 0;

        public CityPage(List<classes.City> citiesRe)
        {
            InitializeComponent();

            this.cities = citiesRe;
            CityList.Text = "";

            for (int i = 0; i < cities.Count; i++)
            {
                NamesSelection.Items.Add(cities[i].Name);
            }

            for(int i = 0; i < 10; i++)
            {
                CityList.Text +=
                    $"{cities[i].Name}; Country - {cities[i].CountryName};" +
                    $"Latitude - {cities[i].Latitude}; " +
                    $"Longtitude - {cities[i].Longitude}; " +
                    $"Population - {cities[i].Population}\n";
            }

            SearchParameter.Items.AddRange(new string[]{
                "Name", "Latitude", "Longtitude", "Population", "Country"
            });

            SortList.Items.AddRange(new string[]{
                "Name", "Latitude", "Longtitude", "Population" }
                );
        }

        private void sortCity(object sender, EventArgs e)
        {
            if (SortList.SelectedItem == "Name")
            {
                cities = cities.OrderBy(o => o.Name).ToList();
            }
            if (SortList.SelectedItem == "Latitude")
            {
                cities = cities.OrderBy(o => -o.Latitude).ToList();
            }
            if (SortList.SelectedItem == "Longtitude")
            {
                cities = cities.OrderBy(o => -o.Longitude).ToList();
            }
            if (SortList.SelectedItem == "Population")
            {
                cities = cities.OrderBy(o => -o.Population).ToList();
            }

            CityList.Text = "";
            for (int i = 0; i < 10; i++)
            {
                if (curFirstCity + i <= cities.Count - 1)
                    CityList.Text +=
                        $"{cities[curFirstCity + i].Name}; " +
                        $"Country - {cities[curFirstCity + i].CountryName};" +
                        $"Latitude - {cities[curFirstCity + i].Latitude}; " +
                        $"Longtitude - {cities[curFirstCity + i].Longitude}; " +
                        $"Population - {cities[curFirstCity + i].Population}\n";
            }
        }

        private void searchByName(string value)
        {
            CityList.Text = "";
            foreach (classes.City city in cities)
            {
                if (city.Name == value)
                {
                    CityList.Text +=
                        $"{city.Name}; " +
                        $"Latitude - {city.Latitude}; " +
                        $"Longtitude - {city.Longitude}; " +
                        $"Population - {city.Population}\n";
                }
            }
        }

        private void searchByLatitude(string value)
        {
            CityList.Text = "";
            foreach (classes.City city in cities)
            {
                if (city.Latitude.ToString() == value)
                {
                    CityList.Text +=
                        $"{city.Name}; " +
                        $"Latitude - {city.Latitude}; " +
                        $"Longtitude - {city.Longitude}; " +
                        $"Population - {city.Population}\n";
                }
            }
        }

        private void searchByLongtitude(string value)
        {
            CityList.Text = "";
            foreach (classes.City city in cities)
            {
                if (city.Longitude.ToString() == value)
                {
                    CityList.Text +=
                        $"{city.Name}; " +
                        $"Latitude - {city.Latitude}; " +
                        $"Longtitude - {city.Longitude}; " +
                        $"Population - {city.Population}\n";
                }
            }
        }

        private void searchByPopulation(string value)
        {
            CityList.Text = "";
            foreach (classes.City city in cities)
            {
                if (city.Population.ToString() == value)
                {
                    CityList.Text +=
                        $"{city.Name}; " +
                        $"Latitude - {city.Latitude}; " +
                        $"Longtitude - {city.Longitude}; " +
                        $"Population - {city.Population}\n";
                }
            }
        }

        private void onSearchButtonClick(object sender, EventArgs e)
        {
            switch (SearchParameter.SelectedItem)
            {
                case "Name":
                    searchByName(SearchValue.Text.ToString());
                    break;
                case "Latitude":
                    searchByLatitude(SearchValue.Text.ToString());
                    break;
                case "Longtitude":
                    searchByLongtitude(SearchValue.Text.ToString());
                    break;
                case "Population":
                    searchByPopulation(SearchValue.Text.ToString());
                    break;
                default:
                    CityList.Text = "Wrong Parameter";
                    break;
            }
        }

        private void onMapButtonClick(object sender, EventArgs e)
        {
            List<int> cityIndex = new List<int> { };
            for (int i = 0; i < cities.Count; i++)
            {
                if(NamesSelection.SelectedItem == null)
                {
                    Dialog diForm = new Dialog();
                    DialogResult dialog = diForm.ShowDialog(this);
                    if (dialog == DialogResult.Cancel)
                    {
                        diForm.Close();
                    }
                    else if (dialog == DialogResult.OK)
                    {
                        diForm.Close();
                    }
                }
                else
                {
                    if (cities[i].Name == NamesSelection.SelectedItem.ToString())
                    {
                        cityIndex.Add(i);
                    }
                }

            }

            CitySelectorPage page = new CitySelectorPage(cities, cityIndex);
            page.Show();
            Hide();
        }

        private void onBackButtonClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainPage form = new MainPage();
                form.Show();
                this.Close();
            }
        }

        public void leftText(object sender, EventArgs e)
        {
            if(curFirstCity>9)
            {
                CityList.Text = "";
                curFirstCity -= 10;
                for (int i = 0; i < 10; i++)
                {
                    CityList.Text +=
                        $"{cities[curFirstCity + i].Name}; " +
                        $"Country - {cities[curFirstCity + i].CountryName};" +
                        $"Latitude - {cities[curFirstCity + i].Latitude}; " +
                        $"Longtitude - {cities[curFirstCity + i].Longitude}; " +
                        $"Population - {cities[curFirstCity + i].Population}\n";
                }
            }
        }

        public void rightText(object sender, EventArgs e)
        {

            if (curFirstCity + 10 <= cities.Count - 1)
            {
                CityList.Text = "";
                curFirstCity += 10;
                for (int i = 0; i < 10; i++)
                {
                    if (curFirstCity + i <= cities.Count - 1)
                    CityList.Text +=
                        $"{cities[curFirstCity + i].Name}; " +
                        $"Country - {cities[curFirstCity + i].CountryName};" +
                        $"Latitude - {cities[curFirstCity + i].Latitude}; " +
                        $"Longtitude - {cities[curFirstCity + i].Longitude}; " +
                        $"Population - {cities[curFirstCity + i].Population}\n";
                }
            }
        }

        private void CityPage_KeyDown(object sender, KeyEventArgs e)
            => onBackButtonClick(sender, e);

        private void SearchButton_Click(object sender, EventArgs e)
            => onSearchButtonClick(sender, e);

        private void MapButton_Click(object sender, EventArgs e)
            => onMapButtonClick(sender, e);

        private void CityPage_Load(object sender, EventArgs e)
        {

        }

        private void leftButton_Click(object sender, EventArgs e)
            => leftText(sender, e);

        private void rightButton_Click(object sender, EventArgs e)
            => rightText(sender, e);

        private void sortButton_Click(object sender, EventArgs e)
            => sortCity(sender, e);
    }
}
