﻿using System;
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
using System.Text.RegularExpressions;

namespace TaxCalculator
{
    public partial class MainPage : Form
    {
        Employee[] employees = new Employee[300]; //global array to store employees in
        int eIndex = 0;

        Contractor[] contractors = new Contractor[300]; //global array to store contractors in
        int cIndex = 0;

        

        String[] rates;
        String[] brackets;

        Regex regEmail = new Regex(@"^(\w|\d|_)+@\w+\.\w{2,3}(\.\w{2,3})?(\.\w{2,3})?$"); // Matches most emails that are commonly used.
        Regex regEmpE = new Regex(@"^[Ee]\d{4}$");//Matches a valid employee ID only / Employee.
        Regex regEmpC = new Regex(@"^[Cc]\d{4}$");//Matches a valid employee ID only / Contractor.

        public MainPage()
        {
            InitializeComponent();
            // Uncomment this block to enable quick testing features, such as Quick Fill Info
            /*
            btnFillGreg.Visible = true;
            btnFillSally.Visible = true;
            btnFillRick.Visible = true;
            btnFillHarry.Visible = true;
            */
            //Touch nothing below this line
            txtGender.DropDownStyle = ComboBoxStyle.DropDownList; // disabling the drop down boxes text field.
            txtDepartment.DropDownStyle = ComboBoxStyle.DropDownList;

            txtHoursWork.Visible = false; // setting the hours worked info to not be visible on program start up
            lblHoursWork.Visible = false;

            //Reading the rates.txt and assinging values into the rates and brackets arrays.
            getRates();
        }

        
        private void getRates()
        {
            string txtBrackets, txtRates;
            string filePath = System.IO.Path.GetFullPath("rates.txt");
            StreamReader SR = new StreamReader(filePath);
            txtBrackets = SR.ReadLine(); // Read the first line , Since there is only 2 lines no need to a loop.
            txtRates = SR.ReadLine(); // Read the second.
            
            string[] stringSeparators = new string[] { ", " }; //String to split at
            brackets = txtBrackets.Split(stringSeparators, StringSplitOptions.None); //Split each string at the seperator into an array.
            rates = txtRates.Split(stringSeparators, StringSplitOptions.None);
            Array.ConvertAll(brackets, Decimal.Parse); // Convert all the strings in the array to Decimal Data Type
            Array.ConvertAll(rates, Decimal.Parse);
            
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if(txtEmployeeID.Text.ToLower().StartsWith("c")) // checking to see if the employee ID starts with e or E. 
            {
                txtHoursWork.Visible = true; //set the hours worked info to visible if true.
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

            if (txtFirstName.Text == String.Empty || txtSurname.Text == String.Empty || !regEmail.IsMatch(txtEmail.Text) || txtGender.Text == String.Empty || txtDepartment.Text == String.Empty || txtHourlyRate.Text == String.Empty)
            {
                MessageBox.Show("Employee entry failed! \nPlease make sure all fields are filled out correctly\nclick Create Employee once the issue is rectified");
            }

            else if (alreadyExists(0))
            {
                MessageBox.Show("Employee ID already exists \nPlease make sure the Employee ID is correct\nclick Create Employee once the issue is rectified");
            }
            else if (!regEmpE.IsMatch(txtCrtEmployeeID.Text))
            {
                MessageBox.Show("Employee ID is Invalid  \nPlease make sure the Employee ID is correct\nFormat: E###\nClick Create Employee once the issue is rectified");
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
                employees[eIndex].EmployeeID = txtCrtEmployeeID.Text.ToUpper();
                employees[eIndex].HourlyRate = decimal.Parse(txtHourlyRate.Text);

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
                
            }
           
        }

        private void btnCrtContractor_Click(object sender, EventArgs e)
        {
            
            if(txtFirstName.Text == String.Empty || txtSurname.Text == String.Empty || txtEmail.Text == String.Empty || txtGender.Text == String.Empty || txtDepartment.Text == String.Empty || txtHourlyRate.Text == String.Empty)
            {
                MessageBox.Show("Contractor entry failed! \nPlease make sure all fields are filled out correctly\nclick Create Contractor once the issue is rectified");
            }
            else if (alreadyExists(1))
            {
                MessageBox.Show("Employee ID already exists \nPlease make sure the Employee ID is correct\nclick Create Contractor once the issue is rectified");
            }
            else if (!regEmpC.IsMatch(txtCrtEmployeeID.Text))
            {
                MessageBox.Show("Employee ID is Invalid  \nPlease make sure the Employee ID is correct\nFormat: C###\nClick Create Contractor once the issue is rectified");
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
                contractors[cIndex].HourlyRate = decimal.Parse(txtHourlyRate.Text);
                contractors[cIndex].EmployeeID = txtCrtEmployeeID.Text.ToUpper();

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
                
            }

            
        }
        
        private Boolean alreadyExists(int x)
        {
            if (x == 0)
            {
                for (var i = 0; i < employees.Length; i++)
                {
                    if (employees[i] != null)
                    {
                        if (txtCrtEmployeeID.Text.ToUpper() == employees[i].EmployeeID)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
                for (var i = 0; i < contractors.Length; i++)
                {
                    if (contractors[i] != null)
                    {
                        if (txtCrtEmployeeID.Text.ToUpper() == contractors[i].EmployeeID)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            

        }

    

        private void btnCalEmTax_Click(object sender, EventArgs e)
        {
            int index; // declaring the index as a vairble so it is not outside the scope as I am using the Try catch block.
            Regex rgx = new Regex(@"^e\d{4}$"); // Making sure the that employeeID entered in valid. e follwed by 4 digits exactly.
            if (!rgx.IsMatch(txtEmployeeID.Text.ToLower()))
            {
                MessageBox.Show("Operation failed\nPlease ensure that both Employee ID is correct\nFormat Employee ID: E###");
            }
            else
            {
                try
                {
                    index = Array.FindIndex(employees, a => a.EmployeeID == txtEmployeeID.Text.ToUpper()); //getting the index of the contractors array that matches the employeeID entered
                }
                catch
                {
                    MessageBox.Show("The Employee ID you entered does not exist");
                    return; //Leave the method.
                }
                
                employeeTaxRate(index);

                saveFilePath.FileName = "Tax Report " + employees[index].EmployeeID + " " + employees[index].FirstName + " " + employees[index].Surname; //setting the file name to ID + Name
                saveFilePath.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFilePath.DefaultExt = "pdf";
                saveFilePath.ShowDialog();
                string newFile = saveFilePath.FileName;
                string pdfTemplatePath = System.IO.Path.GetFullPath("taxTemplate.pdf"); //pdf Template location

                string fullName = employees[index].FirstName + " " + employees[index].Surname;



                PdfReader pdfReader = new PdfReader(pdfTemplatePath);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
                AcroFields pdfFormFields = pdfStamper.AcroFields;
                //Set all the fields in the pdf to their correct values.
                pdfFormFields.SetField("EmployeeID", employees[index].EmployeeID);
                pdfFormFields.SetField("Name", fullName);
                pdfFormFields.SetField("Department", employees[index].Department);
                pdfFormFields.SetField("Salary", "$" + (employees[index].HourlyRate) * 40);
                pdfFormFields.SetField("TaxPayable", "$" + (employees[index].TaxRate).ToString("0.00")); //Display tax payable to 2 decimal places.

                pdfStamper.FormFlattening = true; //making the pdf fields no longer editable

                pdfStamper.Close(); //close the PDF
            }

        }


        private void btnCalCoTax_Click(object sender, EventArgs e)
        {
            int index; // declaring the index as a vairble so it is not outside the scope as I am using the Try catch block.
            Regex rgx = new Regex(@"^c\d{4}$"); // checks to match C####
            Regex rgxHours = new Regex(@"^(\d+(\.\d{1,2})?|[.](\d{1,2})?)$"); // checks to match a valid hours worked
            if (!rgx.IsMatch(txtEmployeeID.Text.ToLower()) || !rgxHours.IsMatch(txtHoursWork.Text))
            {
                MessageBox.Show("Operation failed\nPlease ensure that both Employee ID and Hours Worked are correct\nFormat Employee ID: C###");
            }
            else
            {
                try
                {
                    index = Array.FindIndex(contractors, a => a.EmployeeID == txtEmployeeID.Text.ToUpper()); //getting the index of the contractors array that matches the employeeID entered
                }
                catch
                {
                    MessageBox.Show("The Employee ID you entered does not exist");
                    return; //Leave the method.
                }
                


                saveFilePath.FileName = "Tax Report " + contractors[index].EmployeeID + " " + contractors[index].FirstName + " " + contractors[index].Surname; //setting the file name to ID + Name
                saveFilePath.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFilePath.DefaultExt = "pdf";
                saveFilePath.ShowDialog();
                string newFile = saveFilePath.FileName;
                
                string pdfTemplatePath = System.IO.Path.GetFullPath("taxTemplate.pdf"); //pdf Template location

                string fullName = contractors[index].FirstName + " " + contractors[index].Surname;



                PdfReader pdfReader = new PdfReader(pdfTemplatePath);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
                AcroFields pdfFormFields = pdfStamper.AcroFields;
                //Set all the fields to their correct values.
                pdfFormFields.SetField("EmployeeID", contractors[index].EmployeeID);
                pdfFormFields.SetField("Name", fullName);
                pdfFormFields.SetField("Department", contractors[index].Department);
                pdfFormFields.SetField("Salary", "$" + (contractors[index].HourlyRate) * decimal.Parse(txtHoursWork.Text));
                pdfFormFields.SetField("TaxPayable", "$" + ((contractors[index].HourlyRate) * decimal.Parse(txtHoursWork.Text) * contractors[index].TaxRate).ToString("0.00"));

                pdfStamper.FormFlattening = true; //making the pdf fields no longer editable

                pdfStamper.Close(); //close the PDF
            }
            
        }


        // Since an employee will always pay a certain amount once they pass a certain pay threshold, a simple if statement can be used to determine how much tax they should pay.
        // If the tax rates change to something else this code will need to be modified.
        private void employeeTaxRate(int index)
        {
            int[] maxBracket = new int[5] { 25, 75, 150, 250, 300 };
            decimal employeeSalary = 40 * employees[index].HourlyRate;
            if (employeeSalary >= 2000)
            {
                employees[index].TaxRate = maxBracket[3] + (employeeSalary - decimal.Parse(brackets[3])) * decimal.Parse(rates[4]);
            }
            else if (employeeSalary >= 1500 && employeeSalary < 2000)
            {
                employees[index].TaxRate = maxBracket[2] + (employeeSalary - decimal.Parse(brackets[2])) * decimal.Parse(rates[3]);
            }
            else if (employeeSalary >= 1000 && employeeSalary < 1500)
            {
                employees[index].TaxRate = maxBracket[1] + (employeeSalary - decimal.Parse(brackets[1])) * decimal.Parse(rates[2]);
            }
            else if (employeeSalary >= 500 && employeeSalary < 1000)
            {
                employees[index].TaxRate = maxBracket[0] + (employeeSalary - decimal.Parse(brackets[0])) * decimal.Parse(rates[1]);
            }
            else if (employeeSalary >= 0 && employeeSalary < 500)
            {
                employees[index].TaxRate = employeeSalary  * decimal.Parse(rates[0]);
            }

        }
        

        //Clears all text fields. does not delete or remove any entered employees or contractors.
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



        // These buttons quickly fill in information into the form so that teh developer can quickly test features. 
        // See public mainPage() for section to uncomment to enable this.
        private void btnFillRick_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "Rick";
            txtSurname.Text = "Willcox";
            txtEmail.Text = "rickwillcoxau@outlook.com";
            txtDepartment.Text = "IT";
            txtGender.Text = "Male";
            txtHourlyRate.Text = "42.50";

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
            txtHourlyRate.Text = "29";
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
