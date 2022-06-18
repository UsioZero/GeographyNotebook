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
        private CityPage parent;

        public MapPage(CityPage parent, classes.City city)
        {
            this.parent = parent;


            InitializeComponent();

            Height = 832;
            Width = 1430;
            RedDot.Location =
            new Point(
                Convert.ToInt32(Width / 2 + Width * city.Longitude / 360),
                Convert.ToInt32(Height / 2 - Height * city.Latitude / 360)
            );
        }

        private void onBackButtonClick(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                parent.Show();
                Close();
            }
        }

        private void MapPage_KeyDown(object sender, KeyEventArgs e)
            => onBackButtonClick(e);
    }
}
