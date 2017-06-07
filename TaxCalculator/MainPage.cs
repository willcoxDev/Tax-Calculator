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
        Employee[] employees = new Employee[5]; //global array to store employees in
        int eIndex = 0;

        Contractor[] contractors = new Contractor[5]; //global array to store contractors in
        int cIndex = 0;

        public MainPage()
        {
            InitializeComponent();

            

            txtHoursWork.Visible = false; // setting the hours worked info to not be visible on program start up
            lblHoursWork.Visible = false;
        }

        private void btnCreateEmployeeForm_Click(object sender, EventArgs e)
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

        private void btnCrtEmployee_Click(object sender, EventArgs e)
        {
            employees[eIndex] = new Employee();
            //employees[eIndex].EmployeeID = // the function to create the employee ID
            employees[eIndex].FirstName = txtFirstName.Text;
            employees[eIndex].Surname = txtSurname.Text;
            employees[eIndex].Email = txtSurname.Text;
            employees[eIndex].Gender = txtGender.Text;
            employees[eIndex].Department = txtDepartment.Text;

            txtInformationDisplay.Clear(); //Clear the info display and display new employee
            //txtInformationDisplay.Text += "ID: " + employees[eIndex].EmployeeID + Environment.NewLine;
            txtInformationDisplay.Text += "First name: " + employees[eIndex].FirstName + Environment.NewLine;
            txtInformationDisplay.Text += "Surname: " + employees[eIndex].Surname + Environment.NewLine;
            txtInformationDisplay.Text += "Email: " + employees[eIndex].Email + Environment.NewLine;
            txtInformationDisplay.Text += "Gender: " + employees[eIndex].Gender + Environment.NewLine;
            txtInformationDisplay.Text += "Department: " + employees[eIndex].Department;

            eIndex++; //setting the index to +1 for the next time another employee is created.
        }

        private void btnCrtContractor_Click(object sender, EventArgs e)
        {
            contractors[cIndex] = new Contractor();
            //contractors[cIndex].EmployeeID = // the function to create the contractor ID
            contractors[cIndex].FirstName = txtFirstName.Text;
            contractors[cIndex].Surname = txtSurname.Text;
            contractors[cIndex].Email = txtSurname.Text;
            contractors[cIndex].Gender = txtGender.Text;
            contractors[cIndex].Department = txtDepartment.Text;

            txtInformationDisplay.Clear(); //Clear the info display and display new employee
            //txtInformationDisplay.Text += "ID: " + contractors[eIndex].ContractorID + Environment.NewLine;
            txtInformationDisplay.Text += "First name: " + contractors[cIndex].FirstName + Environment.NewLine;
            txtInformationDisplay.Text += "Surname: " + contractors[cIndex].Surname + Environment.NewLine;
            txtInformationDisplay.Text += "Email: " + contractors[cIndex].Email + Environment.NewLine;
            txtInformationDisplay.Text += "Gender: " + contractors[cIndex].Gender + Environment.NewLine;
            txtInformationDisplay.Text += "Department: " + contractors[cIndex].Department + Environment.NewLine;
            txtInformationDisplay.Text += "Tax Rate: " + (contractors[cIndex].TaxRate * 100) + "%";

            cIndex++; //setting the index to +1 for the next time another contractors is created.
        }
    }
}
