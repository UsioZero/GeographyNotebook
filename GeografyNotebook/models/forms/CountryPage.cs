using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class CountryPage : Form
    {
        int curFirstCountry = 0;
        readonly classes.Database database;
        List<classes.Country> filtredCountries;

        public CountryPage(classes.Database databaseRe)
        {
            database = databaseRe;
            filtredCountries = database.Countries;

            InitializeComponent();

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

            UpdateFiltredCountries();
        }

        private void UpdateFiltredCountries(bool isChangePosition = true)
        {
            if (isChangePosition)
            {
                curFirstCountry = 0;
            }

            filtredCountries = database.GetCountries(
                searchField: SearchParametr.SelectedItem.ToString(),
                searchValue: SearchValue.Text,
                orderByField: SortTypeSelector.SelectedItem.ToString()
            );

            List<classes.Country> tmpList =
                filtredCountries.Skip(curFirstCountry)
                .Take(curFirstCountry + 10).ToList();

            DataTable dataTable = new DataTable();
            DataRow row;

            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Capital");
            dataTable.Columns.Add("Area");
            dataTable.Columns.Add("Government");
            dataTable.Columns.Add("Population");

            for (int i = 0; i < tmpList.Count; i++)
            {
                row = dataTable.NewRow();
                row["Name"] = tmpList[i].Name;
                row["Capital"] = tmpList[i].Capital.Name;
                row["Area"] = tmpList[i].Area;
                row["Government"] = tmpList[i].GovernmentType;
                row["Population"] = tmpList[i].Population;
                dataTable.Rows.Add(row);
            }

            CountryGrid.DataSource = dataTable;
        }

        private void OnBackButtonClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainPage form = new MainPage();
                form.Show();
                Close();
            }

        }

        private void LeftText(object sender, EventArgs e)
        {
            if (curFirstCountry > 9)
            {
                curFirstCountry -= 10;

                UpdateFiltredCountries();
            }
        }

        private void RightText(object sender, EventArgs e)
        {

            if (curFirstCountry + 10 <= filtredCountries.Count - 1)
            {
                curFirstCountry += 10;

                UpdateFiltredCountries();
            }
        }

        private void CountryPage_KeyDown(object sender, KeyEventArgs e)
            => OnBackButtonClick(sender, e);

        private void LeftButton_Click(object sender, EventArgs e)
            => LeftText(sender, e);

        private void RightButton_Click(object sender, EventArgs e)
            => RightText(sender, e);

        private void SortTypeSelector_SelectedValueChanged(object sender
            , EventArgs e)
        {
            curFirstCountry = 0;

            filtredCountries = database.GetCountries(
                orderByField: SortTypeSelector.SelectedItem.ToString()
                );

            CountryList.Text = "";
            for (int i = 0; i < 10; i++)
            {
                if (curFirstCountry + i <= filtredCountries.Count - 1)
                    CountryList.Text +=
                        $"{filtredCountries[curFirstCountry + i].Name}; Area - " +
                        $"{filtredCountries[curFirstCountry + i].Area}; " +
                        $"Population - " +
                        $"{filtredCountries[curFirstCountry + i].Population}; " +
                        $"Government type - " +
                        $"{filtredCountries[curFirstCountry + i].GovernmentType}; " +
                        $"Capital - " +
                        $"{filtredCountries[curFirstCountry + i].Capital.Name}\n";
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            curFirstCountry = 0;

            filtredCountries = database.GetCountries(
                searchField: SearchParametr.SelectedItem.ToString(),
                searchValue: SearchValue.Text
                );

            CountryList.Text = "";
            for (int i = 0; i < 10; i++)
            {
                if (curFirstCountry + i <= filtredCountries.Count - 1)
                    CountryList.Text +=
                        $"{filtredCountries[curFirstCountry + i].Name}; Area - " +
                        $"{filtredCountries[curFirstCountry + i].Area}; " +
                        $"Population - " +
                        $"{filtredCountries[curFirstCountry + i].Population}; " +
                        $"Government type - " +
                        $"{filtredCountries[curFirstCountry + i].GovernmentType}; " +
                        $"Capital - " +
                        $"{filtredCountries[curFirstCountry + i].Capital.Name}\n";
            }
        }
    }
}
