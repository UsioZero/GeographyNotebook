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
    public partial class CitySelectorPage : Form
    {

        classes.Database database;
        List<classes.City> cities;
        List<int> indexes;

        public CitySelectorPage(classes.Database databaseRe, List<int> indexesRe)
        {
            InitializeComponent();
            database = databaseRe;
            cities = database.cities;
            indexes = indexesRe;

            for(int i = 0; i < indexes.Count; i++)
            {
                CitySelector.Items.Add(cities[indexes[i]].Name + " " + cities[indexes[i]].Population.ToString());
            }
        }

        private void onMapButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < indexes.Count; i++)
            {
                if (CitySelector.SelectedItem == null)
                {
                    Dialog diForm = new Dialog();
                    DialogResult dialog = diForm.ShowDialog(this);
                    if (dialog == DialogResult.Cancel)
                    {
                        diForm.Close();
                    }
                    else if (dialog == DialogResult.OK)
                    {
                        diForm.Close();
                    }
                }
                else
                {
                    if (cities[indexes[i]].Name + " " + cities[indexes[i]].Population.ToString()
                        == CitySelector.SelectedItem.ToString())
                    {
                        MapPage page = new MapPage(database, indexes[i]);
                        page.Show();
                        Hide();
                    }
                }

            }
        }
        private void mapButton_Click(object sender, EventArgs e)
            => onMapButtonClick(sender, e);

        private void OnBackButtonClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainPage form = new MainPage();
                form.Show();
                this.Close();
            }
        }

        private void CitySelectorPage_KeyDown(object sender, KeyEventArgs e)
            => OnBackButtonClick(sender, e);
    }
}
