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
        List<classes.City> filteredCities;
        int curFirstCity = 0;

        public CityPage(classes.Database databaseRe)
        {
            database = databaseRe;
            filteredCities = new List<classes.City>{};

            InitializeComponent();

            SearchParameter.Items.AddRange(new string[]{
                "Name", "Latitude", "Longitude", "Population", "CountryName"
            });
            SearchParameter.SelectedItem = SearchParameter.Items[0];

            SortParametr.Items.AddRange(new string[]{
                "Name", "Latitude", "Longitude", "Population", "CountryName"
            });
            SortParametr.SelectedItem = SortParametr.Items[0];

            updateFilteredCities();
            CitiesGrid.DataSource = filteredCities.Take(10).ToList();
            
            for (int i = 0; i < database.cities.Count; i++)
            {
                CityOnMapSelector.Items.Add(database.cities[i].Name);
            }
        }

        public void updateFilteredCities(bool changePosition = true)
        {
            if (changePosition) {
                curFirstCity = 0;
            }

            filteredCities = database.GetCities(
                    searchField: SearchParameter.SelectedItem.ToString(),
                    searchValue: SearchValue.Text,
                    orderByField: SortParametr.SelectedItem.ToString()
            );

            CitiesGrid.DataSource = filteredCities.Skip(curFirstCity).Take(10).ToList();
        }

        private void OnBack()
        {
            MainPage form = new MainPage();
            form.Show();
            Close();
        }

        private void CityPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                OnBack();
            }
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            updateFilteredCities();
        }

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

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (curFirstCity != 0) {
                curFirstCity -= 10;

                CitiesGrid.DataSource = filteredCities.Skip(curFirstCity).Take(10).ToList();
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (curFirstCity <= filteredCities.Count - 10) {
                curFirstCity += 10;
                CitiesGrid.DataSource = filteredCities.Skip(curFirstCity).Take(10).ToList();
            }
        }

        private void EditCityButton_Click(object sender, EventArgs e)
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

        private void AddCityButton_Click(object sender, EventArgs e)
        {

        }

        private void SortParametr_SelectedValueChanged(object sender, EventArgs e)
        {
            updateFilteredCities();
        }

        private void CitiesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                classes.City city = filteredCities[curFirstCity + e.RowIndex];

                AddOrChangeCityPage editForm = new AddOrChangeCityPage(this, database, city);
                editForm.Show();
                Hide();
            }

            if (e.ColumnIndex == 6)
            {
                Console.WriteLine("Map action");
            }
        }
    }
}
