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
        classes.City city;

        public AddOrChangeCityPage(classes.Database databaseRe, classes.City? cityRe)
        {
            database = databaseRe;
            city = cityRe;
            InitializeComponent();



            if(city != null)
            {
                NameTextBox.Text = city.Name;
                CountrySelector.SelectedItem = CountrySelector.Items.
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            Close();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (city == null)
            {
                database.AddCity(new classes.City(
                    uuid: Guid.NewGuid(),
                    name: NameTextBox.Text,
                    countryName: CountrySelector.SelectedItem.ToString(),
                    latitude: Convert.ToDouble(LatitudeNumber.Value),
                    longitude: Convert.ToDouble(LatitudeNumber.Value),
                    population: Convert.ToInt32(PopulationNumber.Value)
                    ));
            }
            else
            {
                city = new classes.City(
                    uuid: Guid.NewGuid(),
                    name: NameTextBox.Text,
                    countryName: CountrySelector.SelectedItem.ToString(),
                    latitude: Convert.ToDouble(LatitudeNumber.Value),
                    longitude: Convert.ToDouble(LatitudeNumber.Value),
                    population: Convert.ToInt32(PopulationNumber.Value)
                    );

                database.UpdateCity(city);
            }
        }
    }
}
