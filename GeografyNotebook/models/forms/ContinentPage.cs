using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class ContinentPage : Form
    {
        readonly classes.Database database;
        readonly List<classes.Continent> continents;
        
        public ContinentPage(classes.Database databaseRe)
        {
            database = databaseRe;
            continents = database.Continents;

            InitializeComponent();
            ContinentList.Text = "";
            for (int i = 0; i < continents.Count; i++)
            {
                ContinentList.Text +=
                    $"{continents[i].Name}; " +
                    $"Population - {continents[i].Population}; " + 
                    $"Countries:";
                for(int j = 0; j < 6; j++)
                {
                    ContinentList.Text 
                        += $" {continents[i].Countries[j].Name} ";
                }
                ContinentList.Text += "...\n";
            }
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
        private void ContinentPage_KeyDown(object sender, KeyEventArgs e)
            => onBackButtonClick(sender, e);
    }
}
