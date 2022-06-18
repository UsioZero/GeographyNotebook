using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class AddOrChangeCountryPage : Form
    {
        readonly classes.Database database;
        readonly classes.Country? country;
        readonly CountryPage parent;

        public AddOrChangeCountryPage(CountryPage countryPage,
            classes.Database databaseRe,
            classes.Country? countryRe = null)
        {
            parent = countryPage;
            database = databaseRe;
            country = countryRe;

            InitializeComponent();

            PopulationNumber.Maximum = Decimal.MaxValue;
            PopulationNumber.Minimum = Decimal.MinValue;

            AreaNumber.Maximum = Decimal.MaxValue;
            AreaNumber.Minimum = Decimal.MinValue;

            CapitalSelector.Items.AddRange(database.Cities
                .Select(city => city.Name)
                .ToList()
                .Where((names, i) => names[i] != names[i-1])
                .ToArray()
                );

            if(country != null)
            {
                NameTextBox.Text = country.Name;
                CapitalSelector.SelectedItem = country.Name;
                GovernmentTypeTextBox.Text = country.GovernmentType;
                AreaNumber.Value = Convert.ToDecimal(country.Area);
                PopulationNumber.Value = Convert.ToDecimal(country.Population);
            }
        }

        private void CloseThisPage()
        {
            parent.UpdateFiltredCountries(false);
            parent.Show();
            Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CloseThisPage();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            classes.Country updatetCountry = new classes.Country(
                uuid: country == null ? Guid.NewGuid() : country.Uuid,
                name: NameTextBox.Text,
                area: Convert.ToInt32(AreaNumber.Value),
                population: Convert.ToInt32(PopulationNumber.Value),
                governmentType: GovernmentTypeTextBox.Text,
                capital: database.Cities.Find(city => city.Name 
                    == CapitalSelector.SelectedItem.ToString())
                );

            if(country == null)
            {
                database.AddCountry(updatetCountry);
            }
            else
            {
                database.UpdateCountry(updatetCountry);
            }

            CloseThisPage();
        }
    }
}
