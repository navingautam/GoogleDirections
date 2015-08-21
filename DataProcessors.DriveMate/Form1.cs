using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataProcessors.DriveMate
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnFindDirections_Click(object sender, EventArgs e)
        {
            DirectionsHelper dh = new DirectionsHelper();
            string waypoints = txtWaypoints.Text;
            string alternatives = "false";
            if (radioYes.Checked == true)
                alternatives = "true";

            if (txtFrom.Text != String.Empty && txtTo.Text != String.Empty)
            {
                bool success = dh.getDirections(txtFrom.Text, txtTo.Text, alternatives, waypoints);
                if (success)
                {
                    lblStatus.Text = "Successfully got directions";
                    txtFrom.Clear();
                    txtTo.Clear();
                    txtWaypoints.Clear();
                    radioNo.Checked = true;
                    System.Diagnostics.Process.Start("directions_file.html");
                }
                else
                {
                    lblStatus.Text = "Failed to get directions!!";
                }
            }
            else
            {
                lblStatus.Text = "Origin and Destination cannot be empty!!";
            }
           
        }
    }
}
