using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class AddOrChangeCityPage : Form
    {
        readonly classes.Database database;
        readonly CityPage parent;
        readonly classes.City? city;

        public AddOrChangeCityPage(CityPage cityPage,
            classes.Database databaseRe,
            classes.City? cityRe = null)
        {
            database = databaseRe;
            parent = cityPage;
            city = cityRe;

            InitializeComponent();

            PopulationNumber.Maximum = Decimal.MaxValue;

            LatitudeNumber.Maximum = 180;
            LatitudeNumber.Minimum = -180;

            LongtitudeNumber.Maximum = 180;
            LongtitudeNumber.Minimum = -180;

            CountrySelector.Items.AddRange(database.Countries
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

        private void CloseThisPage()
        {
            parent.UpdateFilteredCities(false);
            parent.Show();
            Close();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            CloseThisPage();
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            classes.City updatedCity = new classes.City(
                uuid: city != null ?city.Uuid : Guid.NewGuid(),
                name: NameTextBox.Text,
                countryName: CountrySelector.SelectedItem.ToString(),
                latitude: Convert.ToDouble(LatitudeNumber.Value),
                longitude: Convert.ToDouble(LongtitudeNumber.Value),
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

            CloseThisPage();
        }
    }
}
