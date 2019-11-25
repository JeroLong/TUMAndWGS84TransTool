using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTMAndWGS84TransTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLat.Text = "";
            txtLon.Text = "";
            txtX.Text = "";
            txtY.Text = "";
            txtZone.Text = "";
        }

        private void btnWGS84ToUTM_Click(object sender, EventArgs e)
        {
           double[] xyZone=UTMAndWGS84.LatLonToUTMXY(Convert.ToDouble(txtLat.Text),Convert.ToDouble(txtLon.Text));
            txtX.Text=xyZone[0].ToString();
            txtY.Text = xyZone[1].ToString();
            txtZone.Text = xyZone[2].ToString();
        }

        private void btnUTMToWGS84_Click(object sender, EventArgs e)
        {
            bool blnNorthFlage = true;
            if (rdoN.Checked)
            {
                blnNorthFlage = false;
            }
            double[] xy = UTMAndWGS84.UTMXYToLatLon(Convert.ToDouble(txtX.Text),Convert.ToDouble(txtY.Text),Convert.ToDouble(txtZone.Text),blnNorthFlage);
            txtLat.Text = xy[0].ToString();
            txtLon.Text = xy[1].ToString();
        }
    }
}
