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
        classes.Database database;
        List<classes.City> showedCities;
        int curFirstCity = 0;

        public CityPage(classes.Database databaseRe)
        {
            InitializeComponent();

            database = databaseRe;
            showedCities = database.cities;
            CityList.Text = "";

            for (int i = 0; i < showedCities.Count; i++)
            {
                CityOnMapSelector.Items.Add(showedCities[i].Name);
            }

            for(int i = 0; i < 10; i++)
            {
                CityList.Text +=
                    $"{showedCities[i].Name}; " +
                    $"Country - {showedCities[i].CountryName};" +
                    $"Latitude - {showedCities[i].Latitude}; " +
                    $"Longtitude - {showedCities[i].Longitude}; " +
                    $"Population - {showedCities[i].Population}\n";
            }

            SearchParameter.Items.AddRange(new string[]{
                "Name", "Latitude", "Longtitude", "Population", "Country"
            });

            SortParametr.Items.AddRange(new string[]{
                "Name", "Latitude", "Longtitude", "Population", "Country"
            });
        }

        private void OnBackButtonClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainPage form = new MainPage();
                form.Show();
                this.Close();
            }
        }
        private void CityPage_KeyDown(object sender, KeyEventArgs e)
            => OnBackButtonClick(sender, e);

        private void OnSearchButtonClick(object sender, EventArgs e)
        {
            if (SearchParameter.SelectedItem.ToString().Length > 0 && SearchValue.Text.Length > 0)
            {
                showedCities = database.ChangeCities(
                    searchFild: SearchParameter.SelectedItem.ToString(),
                    searchValue: SearchValue.Text
                    );

                curFirstCity = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (i <= showedCities.Count - 1)
                    {
                        CityList.Text +=
                            $"{showedCities[i].Name}; " +
                            $"Country - {showedCities[i].CountryName};" +
                            $"Latitude - {showedCities[i].Latitude}; " +
                            $"Longtitude - {showedCities[i].Longitude}; " +
                            $"Population - {showedCities[i].Population}\n";
                    }
                }
            }

        }
        private void SearchButton_Click(object sender, EventArgs e)
            => OnSearchButtonClick(sender, e);

        private void OnMapButtonClick(object sender, EventArgs e)
        {
            if (CityOnMapSelector.SelectedItem != null)
            {
                List<int> cityIndex = new List<int> { };

                for (int i = 0; i < database.cities.Count; i++)
                {
                        if (database.cities[i].Name == CityOnMapSelector.SelectedItem.ToString())
                        {
                            cityIndex.Add(i);
                        }
                }

                CitySelectorPage page = new CitySelectorPage(database, cityIndex);
                page.Show();
                Hide();
            }
        }
        private void MapButton_Click(object sender, EventArgs e)
            => OnMapButtonClick(sender, e);

        public void LeftText(object sender, EventArgs e)
        {
            if (curFirstCity > 9)
            {
                CityList.Text = "";
                curFirstCity -= 10;
                for (int i = 0; i < 10; i++)
                {
                    CityList.Text +=
                        $"{showedCities[curFirstCity + i].Name}; " +
                        $"Country - {showedCities[curFirstCity + i].CountryName};" +
                        $"Latitude - {showedCities[curFirstCity + i].Latitude}; " +
                        $"Longtitude - {showedCities[curFirstCity + i].Longitude}; " +
                        $"Population - {showedCities[curFirstCity + i].Population}\n";
                }
            }
        }
        private void LeftButton_Click(object sender, EventArgs e)
            => LeftText(sender, e);

        public void RightText(object sender, EventArgs e)
        {

            if (curFirstCity + 10 <= showedCities.Count - 1)
            {
                CityList.Text = "";
                curFirstCity += 10;
                for (int i = 0; i < 10; i++)
                {
                    if (curFirstCity + i <= showedCities.Count - 1)
                        CityList.Text +=
                            $"{showedCities[curFirstCity + i].Name}; " +
                            $"Country - {showedCities[curFirstCity + i].CountryName};" +
                            $"Latitude - {showedCities[curFirstCity + i].Latitude}; " +
                            $"Longtitude - {showedCities[curFirstCity + i].Longitude}; " +
                            $"Population - {showedCities[curFirstCity + i].Population}\n";
                }
            }
        }
        private void RightButton_Click(object sender, EventArgs e)
            => RightText(sender, e);

        private void SortCities(object sender, EventArgs e)
        {
            showedCities = database.ChangeCities(
                orderByField: SortParametr.Text);

            curFirstCity = 0;

            for (int i = 0; i < 10; i++)
            {
                if (i <= showedCities.Count - 1)
                {
                    CityList.Text +=
                        $"{showedCities[i].Name}; " +
                        $"Country - {showedCities[i].CountryName};" +
                        $"Latitude - {showedCities[i].Latitude}; " +
                        $"Longtitude - {showedCities[i].Longitude}; " +
                        $"Population - {showedCities[i].Population}\n";
                }
            }
        }
        private void SortButton_Click(object sender, EventArgs e)
            => SortCities(sender, e);
    }
}
