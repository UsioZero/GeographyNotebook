using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class AddOrChangeRegionPage : Form
    {
        private readonly classes.Database database;
        private readonly classes.Region? region;
        private readonly RegionPage parent;

        public AddOrChangeRegionPage(RegionPage regionPage,
            classes.Database databaseRe,
            classes.Region? regionRe = null)
        {
            parent = regionPage;
            database = databaseRe;
            region = regionRe;

            InitializeComponent();

            PopulationNumber.Maximum = Decimal.MaxValue;
            PopulationNumber.Minimum = Decimal.MinValue;

            List<string> names = database.Countries
                .Select(country => country.Name)
                .ToList();

            CountrySelector.Items.AddRange(names
                .ToArray()
                );

            if (region != null)
            {
                NameTextBox.Text = region.Name;
                CountrySelector.SelectedItem = region.Country.Name;
                TypeTextBox.Text = region.Type;
                PopulationNumber.Value
                    = Convert.ToDecimal(region.Population);
            }
        }

        private void CloseThisPage()
        {
            parent.UpdateFiltredRegions(false);
            parent.Show();
            Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CloseThisPage();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            classes.Region updatetRegion = new classes.Region(
                uuid: region == null ? Guid.NewGuid() : region.Uuid,
                name: NameTextBox.Text,
                country: database.Countries.Find(coun => coun.Name 
                    == CountrySelector.SelectedItem.ToString()),
                population: Convert.ToInt32(PopulationNumber.Value),
                type: TypeTextBox.Text
                );

            if (region == null)
            {
                database.AddRegion(updatetRegion);
            }
            else
            {
                database.UpdateRegion(updatetRegion);
            }

            CloseThisPage();
        }
    }
}
