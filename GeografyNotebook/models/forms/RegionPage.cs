using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class RegionPage : Form
    {
        int curFirstRegion = 0;
        classes.Database database;
        List<classes.Region> filteredRegions;

        public RegionPage(classes.Database databaseRe)
        {
            database = databaseRe;
            filteredRegions = database.Regions;
            InitializeComponent();
            RegionList.Text = "";
            for (int i = 0; i < 10; i++)
            {
                RegionList.Text +=
                    $"{filteredRegions[i].Name}; " +
                    $"Region type - {filteredRegions[i].Type}; " +
                    $"Country - {filteredRegions[i].Country.Name}; " +
                    $"Capital - {filteredRegions[i].Capital.Name}; " +
                    $"Population - {filteredRegions[i].Population}\n";
            }

            SortTypeSelector.Items.AddRange(new string[]{
                "Name",
                "Type",
                "Country",
                "Population"
            });
            SortTypeSelector.SelectedItem = SortTypeSelector.Items[0];

            SearchParametr.Items.AddRange(new string[]{
                "Name",
                "Type",
                "Country",
                "Population"
            });
            SearchParametr.SelectedItem = SearchParametr.Items[0];
        }

        public void LeftText()
        {
            if (curFirstRegion > 9)
            {
                RegionList.Text = "";
                curFirstRegion -= 10;
                for (int i = 0; i < 10; i++)
                {
                    RegionList.Text +=
                        $"{filteredRegions[curFirstRegion + i].Name}; " +
                        $"Region type - " +
                        $"{filteredRegions[curFirstRegion + i].Type}; " +
                        $"Country - " +
                        $"{filteredRegions[curFirstRegion + i].Country.Name}"
                        + $"; Capital - " +
                        $"{filteredRegions[curFirstRegion + i].Capital.Name}"
                        + $"; Population - " +
                        $"{filteredRegions[curFirstRegion + i].Population}\n";
                }
            }
        }
        public void RightText()
        {

            if (curFirstRegion + 10 <= filteredRegions.Count - 1)
            {
                RegionList.Text = "";
                curFirstRegion += 10;
                for (int i = 0; i < 10; i++)
                {
                    if (curFirstRegion + i <= filteredRegions.Count - 1)
                        RegionList.Text +=
                            $"{filteredRegions[curFirstRegion + i].Name}; " +
                            $"Region type - {filteredRegions[curFirstRegion + i].Type}; " +
                            $"Country - {filteredRegions[curFirstRegion + i].Country.Name}; " +
                            $"Capital - {filteredRegions[curFirstRegion + i].Capital.Name}; " +
                            $"Population - {filteredRegions[curFirstRegion + i].Population}\n";
                }
            }
        }

        private void OnBackButtonClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainPage form = new MainPage();
                form.Show();
                Close();
            }
            if (e.KeyData == Keys.Tab)
            {
                RightText();
            }
            if (e.KeyData == (Keys.Tab | Keys.Shift))
            {
                LeftText();
            }
        }
        private void RegionPage_KeyDown(object sender, KeyEventArgs e)
            => OnBackButtonClick(sender, e);

        private void RegionPage_Load(object sender, EventArgs e)
        {

        }

        private void LeftButton_Click(object sender, EventArgs e)
            => LeftText();

        private void RightButton_Click(object sender, EventArgs e)
            => RightText();

        private void SortTypeSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            curFirstRegion = 0;

            filteredRegions = database.GetRegions(
                orderByField: SortTypeSelector.SelectedItem.ToString()
            );

            RegionList.Text = "";
            for (int i = 0; i < 10; i++)
            {
                RegionList.Text +=
                    $"{filteredRegions[i].Name}; " +
                    $"Region type - {filteredRegions[i].Type}; " +
                    $"Country - {filteredRegions[i].Country.Name}; " +
                    $"Capital - {filteredRegions[i].Capital.Name}; " +
                    $"Population - {filteredRegions[i].Population}\n";
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            curFirstRegion = 0;

            filteredRegions = database.GetRegions(
                searchField: SearchParametr.SelectedItem.ToString(),
                searchValue: SearchValue.Text
            );

            RegionList.Text = "";
            for (int i = 0; i < 10; i++)
            {
                if(curFirstRegion + i <= filteredRegions.Count - 1)
                RegionList.Text +=
                    $"{filteredRegions[i].Name}; " +
                    $"Region type - {filteredRegions[i].Type}; " +
                    $"Country - {filteredRegions[i].Country.Name}; " +
                    $"Capital - {filteredRegions[i].Capital.Name}; " +
                    $"Population - {filteredRegions[i].Population}\n";
            }
        }
    }
}
