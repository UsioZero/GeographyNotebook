using System;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class MainPage : Form
    {
        readonly classes.Database database = new classes.Database();

        public MainPage()
        {
            InitializeComponent();    
        }

        private void CityButton_Click(object sender, EventArgs e)
        {
            Form form = new CityPage(database);
            form.Show();
            Hide();
        }

        private void RegionButton_Click(object sender, EventArgs e)
        {
            Form form = new RegionPage(database);
            form.Show();
            Hide();
        }

        private void CountryButton_Click(object sender, EventArgs e)
        {
            Form form = new CountryPage(database);
            form.Show();
            Hide();
        }

        private void ContinentButton_Click(object sender, EventArgs e)
        {
            Form form = new ContinentPage(database);
            form.Show();
            Hide();
        }

        private void MainPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
