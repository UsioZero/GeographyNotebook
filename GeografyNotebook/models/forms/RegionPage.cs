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
    public partial class RegionPage : Form
    {
        int curFirstRegion = 0;
        List<classes.Region> regions;

        public RegionPage(List<classes.Region> regionsRe)
        {
            regions = regionsRe;
            InitializeComponent();
            RegionList.Text = "";
            for (int i = 0; i < 10; i++)
            {
                RegionList.Text +=
                    $"{regions[i].Name}; " +
                    $"Region type - {regions[i].Type}; " +
                    $"Country - {regions[i].Country.Name}; " +
                    $"Capital - {regions[i].Capital.Name}; " +
                    $"Population - {regions[i].Population}\n";
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

        public void leftText(object sender, EventArgs e)
        {
            if (curFirstRegion > 9)
            {
                RegionList.Text = "";
                curFirstRegion -= 10;
                for (int i = 0; i < 10; i++)
                {
                    RegionList.Text +=
                        $"{regions[curFirstRegion + i].Name}; " +
                        $"Region type - {regions[curFirstRegion + i].Type}; " +
                        $"Country - {regions[curFirstRegion + i].Country.Name}; " +
                        $"Capital - {regions[curFirstRegion + i].Capital.Name}; " +
                        $"Population - {regions[curFirstRegion + i].Population}\n";
                }
            }
        }

        public void rightText(object sender, EventArgs e)
        {

            if (curFirstRegion + 10 <= regions.Count - 1)
            {
                RegionList.Text = "";
                curFirstRegion += 10;
                for (int i = 0; i < 10; i++)
                {
                    if (curFirstRegion + i <= regions.Count - 1)
                        RegionList.Text +=
                            $"{regions[curFirstRegion + i].Name}; " +
                            $"Region type - {regions[curFirstRegion + i].Type}; " +
                            $"Country - {regions[curFirstRegion + i].Country.Name}; " +
                            $"Capital - {regions[curFirstRegion + i].Capital.Name}; " +
                            $"Population - {regions[curFirstRegion + i].Population}\n";
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
    }
}
