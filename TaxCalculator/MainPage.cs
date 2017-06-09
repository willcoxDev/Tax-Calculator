using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp;
using iTextSharp.text;
using System.IO;



namespace TaxCalculator
{
    public partial class MainPage : Form
    {
        Employee[] employees = new Employee[3000]; //global array to store employees in
        int eIndex = 0;

        Contractor[] contractors = new Contractor[3000]; //global array to store contractors in
        int cIndex = 0;

        int id = 1000;


        public MainPage()
        {
            InitializeComponent();

            txtGender.DropDownStyle = ComboBoxStyle.DropDownList; // disabling the drop down boxes text field.
            txtDepartment.DropDownStyle = ComboBoxStyle.DropDownList;

            txtHoursWork.Visible = false; // setting the hours worked info to not be visible on program start up
            lblHoursWork.Visible = false;
        }

        private void btnCreateEmployeeForm_Click(object sender, EventArgs e)
        {
            
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if(txtEmployeeID.Text.ToLower().StartsWith("c")) // checking to see if the employee ID starts with e or E. 
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
            if (txtFirstName.Text == String.Empty || txtSurname.Text == String.Empty || txtEmail.Text == String.Empty || txtGender.Text == String.Empty || txtDepartment.Text == String.Empty || txtHourlyRate.Text != String.Empty)
            {
                MessageBox.Show("Employee entry failed! \nPlease make sure all fields are filled out\nclick Create Employee once the issue is rectified");
            }
            else
            {
                employees[eIndex] = new Employee();
                //employees[eIndex].EmployeeID = // the function to create the employee ID
                employees[eIndex].FirstName = txtFirstName.Text;
                employees[eIndex].Surname = txtSurname.Text;
                employees[eIndex].Email = txtEmail.Text;
                employees[eIndex].Gender = txtGender.Text;
                employees[eIndex].Department = txtDepartment.Text;
                employees[eIndex].EmployeeID = "E" + id;
                employees[eIndex].HourlyRate = int.Parse(txtHourlyRate.Text);

                txtInformationDisplay.Clear(); //Clear the info display and display new employee
                txtInformationDisplay.Text += "Employee Created! " +  Environment.NewLine + Environment.NewLine;
                txtInformationDisplay.Text += "ID: " + employees[eIndex].EmployeeID + Environment.NewLine;
                txtInformationDisplay.Text += "First name: " + employees[eIndex].FirstName + Environment.NewLine;
                txtInformationDisplay.Text += "Surname: " + employees[eIndex].Surname + Environment.NewLine;
                txtInformationDisplay.Text += "Email: " + employees[eIndex].Email + Environment.NewLine;
                txtInformationDisplay.Text += "Gender: " + employees[eIndex].Gender + Environment.NewLine;
                txtInformationDisplay.Text += "Department: " + employees[eIndex].Department + Environment.NewLine;
                txtInformationDisplay.Text += "Hourly Rate: $" + employees[eIndex].HourlyRate;

                eIndex++; //setting the index to +1 for the next time another employee is created.
                id++; //makes the ID go up by 1 each time.
            }
           
        }

        private void btnCrtContractor_Click(object sender, EventArgs e)
        {

            if(txtFirstName.Text == String.Empty || txtSurname.Text == String.Empty || txtEmail.Text == String.Empty || txtGender.Text == String.Empty || txtDepartment.Text == String.Empty || txtHourlyRate.Text == String.Empty)
            {
                MessageBox.Show("Contractor entry failed! \nPlease make sure all fields are filled out\nclick Create Contractor once the issue is rectified");
            }
            else
            {
                contractors[cIndex] = new Contractor();
                //contractors[cIndex].EmployeeID = // the function to create the contractor ID
                contractors[cIndex].FirstName = txtFirstName.Text;
                contractors[cIndex].Surname = txtSurname.Text;
                contractors[cIndex].Email = txtEmail.Text;
                contractors[cIndex].Gender = txtGender.Text;
                contractors[cIndex].Department = txtDepartment.Text;
                contractors[cIndex].EmployeeID = "C" + id;

                txtInformationDisplay.Clear(); //Clear the info display and display new employee
                txtInformationDisplay.Text += "Contractor Created! " + Environment.NewLine + Environment.NewLine;
                txtInformationDisplay.Text += "ID: " + contractors[cIndex].EmployeeID + Environment.NewLine;
                txtInformationDisplay.Text += "First name: " + contractors[cIndex].FirstName + Environment.NewLine;
                txtInformationDisplay.Text += "Surname: " + contractors[cIndex].Surname + Environment.NewLine;
                txtInformationDisplay.Text += "Email: " + contractors[cIndex].Email + Environment.NewLine;
                txtInformationDisplay.Text += "Gender: " + contractors[cIndex].Gender + Environment.NewLine;
                txtInformationDisplay.Text += "Department: " + contractors[cIndex].Department + Environment.NewLine;
                txtInformationDisplay.Text += "Hourly Rate: $" + contractors[cIndex].HourlyRate + Environment.NewLine;
                txtInformationDisplay.Text += "Tax Rate: " + (contractors[cIndex].TaxRate * 100) + "%";

                cIndex++; //setting the index to +1 for the next time another contractors is created.
                id++; //makes the ID go up by 1 each time.
            }

            
        }

        private void btnCalCoTax_Click(object sender, EventArgs e)
        {

            var index = Array.FindIndex(contractors, a => a.EmployeeID == txtEmployeeID.Text); //getting the index of the contractors array that matches the employeeID entered


            saveFilePath.FileName = "Tax Report " + contractors[index].EmployeeID + " " + contractors[index].FirstName + " " + contractors[index].Surname; //setting the file name to ID + Name
            saveFilePath.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFilePath.DefaultExt = "pdf";
            saveFilePath.ShowDialog();
            string newFile = saveFilePath.FileName;            

            string pdfTemplate = @"C:\Users\Rick\Desktop\tax calculator\Tax-Calculator\taxTemplate.pdf"; //pdf Template location
  
            string fullName = contractors[index].FirstName + " " + contractors[index].Surname;



            PdfReader pdfReader = new PdfReader(pdfTemplate);
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            //Set all the fields to their correct values.
            pdfFormFields.SetField("EmployeeID", contractors[index].EmployeeID);
            pdfFormFields.SetField("Name", fullName);
            pdfFormFields.SetField("Department", contractors[index].Department);
            pdfFormFields.SetField("Salary", "$40,000,000");
            pdfFormFields.SetField("TaxPayable", "$2");
            
            pdfStamper.FormFlattening = true; //making the pdf fields no longer editable

            pdfStamper.Close(); //close the PDF
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
            txtDepartment.SelectedItem = " ";
            txtGender.SelectedItem = " ";
        }
        // Just a bunch of Quick Fill buttons to save time on typing out test examples each time. To be removed before deployment.
        private void btnFillRick_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "Rick";
            txtSurname.Text = "Willcox";
            txtEmail.Text = "rickwillcoxau@outlook.com";
            txtDepartment.Text = "IT";
            txtGender.Text = "Male";
            txtHourlyRate.Text = "50.50";

        }

        private void btnFillSally_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "Sally";
            txtSurname.Text = "Summers";
            txtEmail.Text = "ss@outlook.com";
            txtDepartment.Text = "Administration";
            txtGender.Text = "Female";
            txtHourlyRate.Text = "80.43";
        }

        private void btnFillGreg_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "Greg";
            txtSurname.Text = "Wialker";
            txtEmail.Text = "GregWialker@outlook.com";
            txtDepartment.Text = "Customer Service";
            txtGender.Text = "Male";
            txtHourlyRate.Text = "25";
        }

        private void btnFillHarry_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "Harry";
            txtSurname.Text = "Willcox";
            txtEmail.Text = "HarryWillcox@outlook.com";
            txtDepartment.Text = "Accounts";
            txtGender.Text = "Male";
            txtHourlyRate.Text = "29S";
        }

        

        private void txtHourlyRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
