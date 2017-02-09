/* Program Written By: 
 * Matthew Bethke
 * Anderew Poppenberg
 * 02/08/17
 * Ch12 GreenVilleAd
 */
using System;
using System.Windows.Forms;

namespace GreensvilleAdvertisement
{
    public partial class GVAForm : Form
    {
        public GVAForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (spectateCB.Checked == true)
            {
                outputLabel.Text = "Spectator Tickets will be availible at the door $5";
            }
            else if (competeCB.Checked == true)
            {
                outputLabel.Text = "Registration forms are still available sign up today!";
            }
            else
                outputLabel.Text = "Please Check one box";

        }
    }
}
