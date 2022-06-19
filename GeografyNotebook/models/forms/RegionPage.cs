using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class RegionPage : Form
    {
        int curFirstRegion = 0;
        readonly classes.Database database;
        List<classes.Region> filteredRegions;

        public RegionPage(classes.Database databaseRe)
        {
            database = databaseRe;
            filteredRegions = database.Regions;

            InitializeComponent();

            SortTypeSelector.Items.AddRange(new string[]{
                "Name",
                "Type",
                "Country",
                "Population"
            });
            SortTypeSelector.SelectedItem = SortTypeSelector.Items[0];

            SearchParam.Items.AddRange(new string[]{
                "Name",
                "Type",
                "Country",
                "Population"
            });
            SearchParam.SelectedItem = "Name";

            UpdateFiltredRegions();

            DataGridViewButtonColumn editButton
                = new DataGridViewButtonColumn
                {
                    UseColumnTextForButtonValue = true,
                    Text = "Edit"
                };
            CountryGrid.Columns.Add(editButton);
        }

        public void UpdateFiltredRegions(bool isChangePosition = true)
        {
            if (isChangePosition)
            {
                curFirstRegion = 0;
            }

            filteredRegions = database.GetRegions(
                searchField: SearchParam.SelectedItem == null
                ? "Name"
                : SearchParam.SelectedItem.ToString(),
                searchValue: SearchValue.Text,
                orderByField: SortTypeSelector.SelectedItem.ToString()
            );

            List<classes.Region> tmpList =
                filteredRegions.Skip(curFirstRegion)
                .Take(10).ToList();

            DataTable dataTable = new DataTable();
            DataRow row;

            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Country");
            dataTable.Columns.Add("Type");
            dataTable.Columns.Add("Population");

            for (int i = 0; i < tmpList.Count; i++)
            {
                row = dataTable.NewRow();
                row["Name"] = tmpList[i].Name;
                row["Country"] = tmpList[i].Country.Name;
                row["Type"] = tmpList[i].Type;
                row["Population"] = tmpList[i].Population;
                dataTable.Rows.Add(row);
            }

            CountryGrid.DataSource = dataTable;

            UpdatePageLabel();
        }

        private void UpdatePageLabel()
        {
            int from = curFirstRegion + 1;
            int to = curFirstRegion + 10 < filteredRegions.Count
                ? curFirstRegion + 10
                : filteredRegions.Count;
            PageLabel.Text = $"{from}-{to} of {filteredRegions.Count}";
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
        private void RegionPage_KeyDown(object sender, KeyEventArgs e)
            => OnBackButtonClick(sender, e);

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (curFirstRegion != 0)
            {
                curFirstRegion -= 10;

                UpdateFiltredRegions(false);
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (curFirstRegion <= filteredRegions.Count - 10)
            {
                curFirstRegion += 10;

                UpdateFiltredRegions(false);
            }
        }

        private void SortTypeSelector_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateFiltredRegions();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            UpdateFiltredRegions();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddOrChangeRegionPage editForm
                = new AddOrChangeRegionPage(this, database);
            editForm.Show();
            Hide();
        }

        private void SaveResultButton_Click(object sender, EventArgs e)
        {
            database.SaveRegionsToFile(filteredRegions,
                @"..\..\assets\search_result.txt");
        }

        private void CountryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                classes.Region region
                    = filteredRegions[curFirstRegion+ e.RowIndex];

                AddOrChangeRegionPage editForm
                    = new AddOrChangeRegionPage(this, database, region);
                editForm.Show();
                Hide();
            }
        }
    }
}
