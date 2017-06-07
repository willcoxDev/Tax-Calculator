using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            txtHoursWork.Visible = false; // setting the hours worked info to not be visible on program start up
            lblHoursWork.Visible = false;
        }

        private void btnCreateEmployeeForm_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if(txtEmployeeID.Text.ToLower().StartsWith("e")) // checking to see if the employee ID starts with e or E. 
            {
                txtHoursWork.Visible = true; //sett the hours worked info to visible if true.
                lblHoursWork.Visible = true;
            }
            else
            {
                txtHoursWork.Visible = false; //removes the hours worked if they delete the e to enter a new ID.
                lblHoursWork.Visible = false;
            }
            
        }
    }
}
