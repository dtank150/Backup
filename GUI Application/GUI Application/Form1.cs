using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Application
{
    public partial class frmReg : Form
    {
        public frmReg()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String address = txtAddress.Text;
            String gender = String.Empty;
            if (rdbFemale.Checked)
            {
                gender = rdbFemale.Text;
            }
            else
            {
                gender = rdbMale.Text;
            }
            String city = cmbCity.Text;
            var mobileNo = nupMobileNo.Value;
            String output = String.Empty;
            output += "Name: " + name;
            output += "\nGender: " + gender;
            output += $"\nCity: {city}";
            output += $"\nMobile No:- {mobileNo}";

            lblOutput.Text = output;
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbFemale.Checked)
            {
                string title = "Female";
                MessageBox.Show("You select female",title);
            }
           /* else
            {
                string title = "Male";
                MessageBox.Show("You select male");

            }*/
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMale.Checked)
            {
                string title = "Male";
                MessageBox.Show("You select male",title);
            }
        }
    }
}
