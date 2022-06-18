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
    public partial class AddOrChangeCityPage : Form
    {
        classes.Database database;
        classes.City? city;
        CityPage parent;

        public AddOrChangeCityPage(CityPage cityPage, classes.Database databaseRe, classes.City? cityRe)
        {
            database = databaseRe;
            parent = cityPage;
            city = cityRe;
            InitializeComponent();

            PopulationNumber.Maximum = Decimal.MaxValue;

            LatitudeNumber.Maximum = Decimal.MaxValue;
            LatitudeNumber.Minimum = Decimal.MinValue;

            LongtitudeNumber.Maximum = Decimal.MaxValue;
            LongtitudeNumber.Minimum = Decimal.MinValue;

            CountrySelector.Items.AddRange(database.countries
                          .Select(r=>r.Name)
                          .ToArray()
            );

            if(city != null)
            {
                NameTextBox.Text = city.Name;
                CountrySelector.SelectedItem = city.CountryName;
                LatitudeNumber.Value = Convert.ToDecimal(city.Latitude);
                LongtitudeNumber.Value = Convert.ToDecimal(city.Longitude);
                PopulationNumber.Value = Convert.ToDecimal(city.Population);
            }
        }

        private void closeThisPage()
        {
            parent.updateFilteredCities(false);
            parent.Show();
            Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            closeThisPage();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            classes.City updatedCity = new classes.City(
                uuid: city != null ?city.Uuid : Guid.NewGuid(),
                name: NameTextBox.Text,
                countryName: CountrySelector.SelectedItem.ToString(),
                latitude: Convert.ToDouble(LatitudeNumber.Value),
                longitude: Convert.ToDouble(LatitudeNumber.Value),
                population: Convert.ToInt32(PopulationNumber.Value)
            );

            if (city == null)
            {
                database.AddCity(updatedCity);
            }
            else
            {
                database.UpdateCity(updatedCity);
            }

            closeThisPage();
        }
    }
}
