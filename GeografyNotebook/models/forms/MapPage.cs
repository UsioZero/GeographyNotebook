using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeografyNotebook.models.forms
{
    public partial class MapPage : Form
    {
        private readonly CityPage parent;

        public MapPage(CityPage parent, classes.City city)
        {
            this.parent = parent;

            InitializeComponent();

            Height = 832;
            Width = 1430;
            RedDot.Location = new Point(
                Convert.ToInt32(Width / 2 + Width * city.Longitude /
                360 - RedDot.Size.Width/2),
                Convert.ToInt32(Height / 2 - Height * city.Latitude /
                360- RedDot.Size.Height/2)
            );
        }

        private void OnBackButtonClick(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                parent.Show();
                Close();
            }
        }

        private void MapPage_KeyDown(object sender, KeyEventArgs e)
            => OnBackButtonClick(e);
    }
}
