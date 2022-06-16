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
    public partial class CountryPage : Form
    {
        List<classes.Country> countries;
        int curFirstCountry = 0;

        public CountryPage(List<classes.Country> countriesRe)
        {
            countries = countriesRe;
            InitializeComponent();
            CountryList.Text = "";
            for (int i = 0; i < 10; i++)
            {
                CountryList.Text +=
                    $"{countries[i].Name}; Area - {countries[i].Area}; " +
                    $"Population - {countries[i].Population}; " +
                    $"Government type - {countries[i].GovernmentType}; " +
                    $"Capital - {countries[i].Capital.Name}\n";
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
                        $"{countries[curFirstCountry + i].Name}; Area - {countries[curFirstCountry + i].Area}; " +
                        $"Population - {countries[curFirstCountry + i].Population}; " +
                        $"Government type - {countries[curFirstCountry + i].GovernmentType}; " +
                        $"Capital - {countries[curFirstCountry + i].Capital.Name}\n";
                }
            }
        }

        public void rightText(object sender, EventArgs e)
        {

            if (curFirstCountry + 10 <= countries.Count - 1)
            {
                CountryList.Text = "";
                curFirstCountry += 10;
                for (int i = 0; i < 10; i++)
                {
                    if (curFirstCountry + i <= countries.Count - 1)
                        CountryList.Text +=
                            $"{countries[curFirstCountry + i].Name}; Area - {countries[curFirstCountry + i].Area}; " +
                            $"Population - {countries[curFirstCountry + i].Population}; " +
                            $"Government type - {countries[curFirstCountry + i].GovernmentType}; " +
                            $"Capital - {countries[curFirstCountry + i].Capital.Name}\n";
                }
            }
        }

        private void sortCountry(object sender, EventArgs e)
        {
            if(SortList.SelectedItem == "Name")
            {
                countries = countries.OrderBy(o => o.Name).ToList();
            }
            if (SortList.SelectedItem == "Area")
            {
                countries = countries.OrderBy(o => -o.Area).ToList();
            }
            if (SortList.SelectedItem == "Population")
            {
                countries = countries.OrderBy(o => -o.Population).ToList();
            }
            if (SortList.SelectedItem == "Government type")
            {
                countries = countries.OrderBy(o => o.GovernmentType).ToList();
            }
            CountryList.Text = "";
            for (int i = 0; i < 10; i++)
            {
                if (curFirstCountry + i <= countries.Count - 1)
                    CountryList.Text +=
                        $"{countries[curFirstCountry + i].Name}; Area - {countries[curFirstCountry + i].Area}; " +
                        $"Population - {countries[curFirstCountry + i].Population}; " +
                        $"Government type - {countries[curFirstCountry + i].GovernmentType}; " +
                        $"Capital - {countries[curFirstCountry + i].Capital.Name}\n";
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
