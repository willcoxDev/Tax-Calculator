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

        String[] rates;
        String[] brackets;
 
        public MainPage()
        {
            InitializeComponent();
            // Uncomment this block to enable quick testing features, such as Quick Fill Info
            ///*
            btnFillGreg.Visible = true;
            btnFillSally.Visible = true;
            btnFillRick.Visible = true;
            btnFillHarry.Visible = true;
            //*/
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
            
            StreamReader SR = new StreamReader(@"C:\Users\Rick\Desktop\tax calculator\Tax-Calculator\Rates.txt");
            txtBrackets = SR.ReadLine(); // Read the first line , Since there is only 2 lines no need to a loop.
            txtRates = SR.ReadLine(); // Read the second.
            
            string[] stringSeparators = new string[] { ", " }; //String to split at
            brackets = txtBrackets.Split(stringSeparators, StringSplitOptions.None); //Split each string at the seperator into an array.
            rates = txtRates.Split(stringSeparators, StringSplitOptions.None);
            Array.ConvertAll(brackets, Decimal.Parse); // Convert all the strings in the array to Double Data Type
            Array.ConvertAll(rates, Decimal.Parse);
            
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
            if (txtFirstName.Text == String.Empty || txtSurname.Text == String.Empty || txtEmail.Text == String.Empty || txtGender.Text == String.Empty || txtDepartment.Text == String.Empty || txtHourlyRate.Text == String.Empty)
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
                contractors[cIndex].HourlyRate = decimal.Parse(txtHourlyRate.Text);
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

        private void btnCalEmTax_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == String.Empty)
            {
                MessageBox.Show("Operation failed\nPlease ensure that both Employee ID is correct");
            }
            else
            {
                var index = Array.FindIndex(employees, a => a.EmployeeID == txtEmployeeID.Text.ToUpper()); //getting the index of the contractors array that matches the employeeID entered
                employeeTaxRate(index);

                saveFilePath.FileName = "Tax Report " + employees[index].EmployeeID + " " + employees[index].FirstName + " " + employees[index].Surname; //setting the file name to ID + Name
                saveFilePath.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFilePath.DefaultExt = "pdf";
                saveFilePath.ShowDialog();
                string newFile = saveFilePath.FileName;

                string pdfTemplate = @"C:\Users\Rick\Desktop\tax calculator\Tax-Calculator\taxTemplate.pdf"; //pdf Template location

                string fullName = employees[index].FirstName + " " + employees[index].Surname;



                PdfReader pdfReader = new PdfReader(pdfTemplate);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
                AcroFields pdfFormFields = pdfStamper.AcroFields;
                //Set all the fields to their correct values.
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
            if(txtEmployeeID.Text == String.Empty || txtHoursWork.Text == String.Empty)
            {
                MessageBox.Show("Operation failed\nPlease ensure that both Employee ID and Hours Worked are correct");
            }
            else
            {
                var index = Array.FindIndex(contractors, a => a.EmployeeID == txtEmployeeID.Text.ToUpper()); //getting the index of the contractors array that matches the employeeID entered


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
                pdfFormFields.SetField("Salary", "$" + (contractors[index].HourlyRate) * decimal.Parse(txtHoursWork.Text));
                pdfFormFields.SetField("TaxPayable", "$" + (contractors[index].HourlyRate) * decimal.Parse(txtHoursWork.Text) * contractors[index].TaxRate);

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
            txtEmployeeID.Text = "e1000";

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
