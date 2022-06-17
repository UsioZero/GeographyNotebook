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
    public partial class MapPage : Form
    {

        classes.Database database;
        List<classes.City> cities;

        public MapPage(classes.Database databaseRe, int index)
        {
            InitializeComponent();
            database = databaseRe;
            this.cities = database.cities;
            this.Height = 832;
            //this.Width = 1430;
            this.Width = 1430;
            this.RedDot.Location =
            new Point(Convert.ToInt32(this.Width / 2
                + this.Width * cities[index].Longitude / 360),
                Convert.ToInt32(this.Height / 2
                - this.Height * cities[index].Latitude / 360)
                );
        }

        private void onBackButtonClick(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CityPage form = new CityPage(database);
                form.Show();
                this.Close();
            }
        }

        private void MapPage_KeyDown(object sender, KeyEventArgs e)
            => onBackButtonClick(e);

        private void MapPage_Load(object sender, EventArgs e)
        {

        }
    }
}
