using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class CountryPage : Form
    {
        int curFirstCountry = 0;
        readonly classes.Database database;
        List<classes.Country> countries;

        public CountryPage(classes.Database databaseRe)
        {
            database = databaseRe;
            countries = database.Countries;

            InitializeComponent();

            CountryList.Text = "";
            for (int i = 0; i < 10; i++)
            {
                CountryList.Text +=
                    $"{countries[i].Name}; " +
                    $"Area - {countries[i].Area}; " +
                    $"Population - {countries[i].Population}; " +
                    $"Government type - " +
                    $"{countries[i].GovernmentType}; " +
                    $"Capital - {countries[i].Capital.Name}\n";
            }

            SortTypeSelector.Items.AddRange(new string[]{
                "Name",
                "Area",
                "Population",
                "Government type"
            });
            SortTypeSelector.SelectedItem = SortTypeSelector.Items[0];

            SearchParametr.Items.AddRange(new string[]{
                "Name",
                "Area",
                "Population",
                "Government type"
            });
            SearchParametr.SelectedItem = SearchParametr.Items[0];
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
        private void LeftText(object sender, EventArgs e)
        {
            if (curFirstCountry > 9)
            {
                CountryList.Text = "";
                curFirstCountry -= 10;
                for (int i = 0; i < 10; i++)
                {
                    CountryList.Text +=
                        $"{countries[curFirstCountry + i].Name}; " +
                        $"Area - " +
                        $"{countries[curFirstCountry + i].Area}; " +
                        $"Population - " +
                        $"{countries[curFirstCountry + i].Population}; " +
                        $"Government type - " +
                        $"{countries[curFirstCountry + i].GovernmentType}; " +
                        $"Capital - " +
                        $"{countries[curFirstCountry + i].Capital.Name}\n";
                }
            }
        }
        private void RightText(object sender, EventArgs e)
        {

            if (curFirstCountry + 10 <= countries.Count - 1)
            {
                CountryList.Text = "";
                curFirstCountry += 10;
                for (int i = 0; i < 10; i++)
                {
                    if (curFirstCountry + i <= countries.Count - 1)
                    {
                        CountryList.Text +=
                            $"{countries[curFirstCountry + i].Name}; " +
                            $"Area - {countries[curFirstCountry + i].Area};" +
                            $" Population - " +
                            $"{countries[curFirstCountry + i].Population}; " +
                            $"Government type - " +
                            $"{countries[curFirstCountry + i].GovernmentType}"
                            + $"; Capital - " +
                            $"{countries[curFirstCountry + i].Capital.Name}\n";
                    }
                }
            }
        }
        private void CountryPage_KeyDown(object sender, KeyEventArgs e)
            => OnBackButtonClick(sender, e);
        private void leftButton_Click(object sender, EventArgs e)
            => LeftText(sender, e);
        private void rightButton_Click(object sender, EventArgs e)
            => RightText(sender, e);
        private void SortTypeSelector_SelectedValueChanged(object sender
            , EventArgs e)
        {
            curFirstCountry = 0;

            countries = database.GetCountries(
                orderByField: SortTypeSelector.SelectedItem.ToString()
                );

            CountryList.Text = "";
            for (int i = 0; i < 10; i++)
            {
                if (curFirstCountry + i <= countries.Count - 1)
                    CountryList.Text +=
                        $"{countries[curFirstCountry + i].Name}; Area - " +
                        $"{countries[curFirstCountry + i].Area}; " +
                        $"Population - " +
                        $"{countries[curFirstCountry + i].Population}; " +
                        $"Government type - " +
                        $"{countries[curFirstCountry + i].GovernmentType}; " +
                        $"Capital - " +
                        $"{countries[curFirstCountry + i].Capital.Name}\n";
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            curFirstCountry = 0;

            countries = database.GetCountries(
                searchField: SearchParametr.SelectedItem.ToString(),
                searchValue: SearchValue.Text
                );

            CountryList.Text = "";
            for (int i = 0; i < 10; i++)
            {
                if (curFirstCountry + i <= countries.Count - 1)
                    CountryList.Text +=
                        $"{countries[curFirstCountry + i].Name}; Area - " +
                        $"{countries[curFirstCountry + i].Area}; " +
                        $"Population - " +
                        $"{countries[curFirstCountry + i].Population}; " +
                        $"Government type - " +
                        $"{countries[curFirstCountry + i].GovernmentType}; " +
                        $"Capital - " +
                        $"{countries[curFirstCountry + i].Capital.Name}\n";
            }
        }
    }
}
