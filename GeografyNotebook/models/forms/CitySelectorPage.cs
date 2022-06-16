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
        List<classes.City> cities;
        List<int> indexes;

        public CitySelectorPage(List<classes.City> citiesRe, List<int> indexesRe)
        {
            cities = citiesRe;
            indexes = indexesRe;
            InitializeComponent();
            for(int i =0; i < indexes.Count; i++)
            {
                CityList.Items.Add(cities[indexes[i]].Name + " " + cities[indexes[i]].Population.ToString());
            }
        }

        private void onMapButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < indexes.Count; i++)
            {
                if (CityList.SelectedItem == null)
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
                        == CityList.SelectedItem.ToString())
                    {
                        MapPage page = new MapPage(cities, indexes[i]);
                        page.Show();
                        Hide();
                    }
                }

            }
        }

        private void mapButton_Click(object sender, EventArgs e)
            => onMapButtonClick(sender, e);
    }
}
