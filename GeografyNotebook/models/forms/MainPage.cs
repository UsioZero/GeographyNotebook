using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class MainPage : Form
    {
        classes.Database database = new classes.Database();

        public MainPage()
        {
            InitializeComponent();    
        }

        private void onCityButtonClick(object sender, EventArgs e)
        {
            Form form = new CityPage(database);
            form.Show();
            Hide();
        }

        private void onRegionButtonClick(object sender, EventArgs e)
        {
            Form form = new RegionPage(database);
            form.Show();
            Hide();
        }

        private void onCountryButtonClick(object sender, EventArgs e)
        {
            Form form = new CountryPage(database);
            form.Show();
            Hide();
        }

        private void onContinentButtonClick(object sender, EventArgs e)
        {
            Form form = new ContinentPage(database);
            form.Show();
            Hide();
        }

        private void onBackButtonClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void CityButton_Click(object sender, EventArgs e)
            => onCityButtonClick(sender, e);

        private void RegionButton_Click(object sender, EventArgs e)
            => onRegionButtonClick(sender, e);

        private void CountryButton_Click(object sender, EventArgs e)
            => onCountryButtonClick(sender, e);

        private void ContinentButton_Click(object sender, EventArgs e)
            => onContinentButtonClick(sender, e);

        private void MainPage_KeyDown(object sender, KeyEventArgs e)
            => onBackButtonClick(sender, e);
    }
}
