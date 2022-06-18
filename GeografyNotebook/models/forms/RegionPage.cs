using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class RegionPage : Form
    {
        classes.Database database;
        List<classes.Region> filteredRegions;
        int curFirstRegion = 0;

        public RegionPage(classes.Database databaseRe)
        {
            database = databaseRe;
            filteredRegions = database.regions;
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
            if (curFirstRegion > 9)
            {
                RegionList.Text = "";
                curFirstRegion -= 10;
                for (int i = 0; i < 10; i++)
                {
                    RegionList.Text +=
                        $"{filteredRegions[curFirstRegion + i].Name}; " +
                        $"Region type - {filteredRegions[curFirstRegion + i].Type}; " +
                        $"Country - {filteredRegions[curFirstRegion + i].Country.Name}; " +
                        $"Capital - {filteredRegions[curFirstRegion + i].Capital.Name}; " +
                        $"Population - {filteredRegions[curFirstRegion + i].Population}\n";
                }
            }
        }

        public void rightText(object sender, EventArgs e)
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

        private void RegionPage_KeyDown(object sender, KeyEventArgs e)
            => onBackButtonClick(sender, e);

        private void RegionPage_Load(object sender, EventArgs e)
        {

        }

        private void leftButton_Click(object sender, EventArgs e)
            => leftText(sender, e);

        private void rightButton_Click(object sender, EventArgs e)
            => rightText(sender, e);

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
    }
}
