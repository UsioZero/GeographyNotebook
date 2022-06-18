using System;
using System.Collections.Generic;
using System.Linq;
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

            UpdateFilteredCities();
            CitiesGrid.DataSource = filteredCities.Take(10).ToList();
        }

        public void UpdateFilteredCities(bool changePosition = true)
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
            UpdateFilteredCities();
        }

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

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            AddOrChangeCityPage editForm = new AddOrChangeCityPage(this, database);
            editForm.Show();
            Hide();
        }

        private void SortParametr_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateFilteredCities();
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
                classes.City city = filteredCities[curFirstCity + e.RowIndex];
                MapPage editForm = new MapPage(this, city);
                editForm.Show();
                Hide();
            }
        }
    }
}
