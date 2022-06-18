using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class CountryPage : Form
    {
        classes.Database database;
        List<classes.Country> filteredCountries;
        int curFirstCountry = 0;

        public CountryPage(classes.Database databaseRe)
        {
            database = databaseRe;
            filteredCountries = database.countries;
            InitializeComponent();
            CountryList.Text = "";
            for (int i = 0; i < 10; i++)
            {
                CountryList.Text +=
                    $"{filteredCountries[i].Name}; " +
                    $"Area - {filteredCountries[i].Area}; " +
                    $"Population - {filteredCountries[i].Population}; " +
                    $"Government type - {filteredCountries[i].GovernmentType}; " +
                    $"Capital - {filteredCountries[i].Capital.Name}\n";
            }
            SortList.Items.AddRange(new string[]{
                "Name",
                "Area",
                "Population",
                "Government type"
            });
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
            if (curFirstCountry > 9)
            {
                CountryList.Text = "";
                curFirstCountry -= 10;
                for (int i = 0; i < 10; i++)
                {
                    CountryList.Text +=
                        $"{filteredCountries[curFirstCountry + i].Name}; Area - {filteredCountries[curFirstCountry + i].Area}; " +
                        $"Population - {filteredCountries[curFirstCountry + i].Population}; " +
                        $"Government type - {filteredCountries[curFirstCountry + i].GovernmentType}; " +
                        $"Capital - {filteredCountries[curFirstCountry + i].Capital.Name}\n";
                }
            }
        }

        public void rightText(object sender, EventArgs e)
        {

            if (curFirstCountry + 10 <= filteredCountries.Count - 1)
            {
                CountryList.Text = "";
                curFirstCountry += 10;
                for (int i = 0; i < 10; i++)
                {
                    if (curFirstCountry + i <= filteredCountries.Count - 1)
                        CountryList.Text +=
                            $"{filteredCountries[curFirstCountry + i].Name}; Area - {filteredCountries[curFirstCountry + i].Area}; " +
                            $"Population - {filteredCountries[curFirstCountry + i].Population}; " +
                            $"Government type - {filteredCountries[curFirstCountry + i].GovernmentType}; " +
                            $"Capital - {filteredCountries[curFirstCountry + i].Capital.Name}\n";
                }
            }
        }

        private void sortCountry(object sender, EventArgs e)
        {
            if(SortList.SelectedItem == "Name")
            {
                filteredCountries = filteredCountries.OrderBy(o => o.Name).ToList();
            }
            if (SortList.SelectedItem == "Area")
            {
                filteredCountries = filteredCountries.OrderBy(o => -o.Area).ToList();
            }
            if (SortList.SelectedItem == "Population")
            {
                filteredCountries = filteredCountries.OrderBy(o => -o.Population).ToList();
            }
            if (SortList.SelectedItem == "Government type")
            {
                filteredCountries = filteredCountries.OrderBy(o => o.GovernmentType).ToList();
            }
            CountryList.Text = "";
            for (int i = 0; i < 10; i++)
            {
                if (curFirstCountry + i <= filteredCountries.Count - 1)
                    CountryList.Text +=
                        $"{filteredCountries[curFirstCountry + i].Name}; Area - {filteredCountries[curFirstCountry + i].Area}; " +
                        $"Population - {filteredCountries[curFirstCountry + i].Population}; " +
                        $"Government type - {filteredCountries[curFirstCountry + i].GovernmentType}; " +
                        $"Capital - {filteredCountries[curFirstCountry + i].Capital.Name}\n";
            }
        }

        private void CountryPage_KeyDown(object sender, KeyEventArgs e)
            => onBackButtonClick(sender, e);

        private void leftButton_Click(object sender, EventArgs e)
            => leftText(sender, e);

        private void rightButton_Click(object sender, EventArgs e)
            => rightText(sender, e);

        private void sortButton_Click(object sender, EventArgs e)
            => sortCountry(sender, e);
    }
}
