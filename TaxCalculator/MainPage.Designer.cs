﻿using System;

namespace TaxCalculator
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblHoursWork = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoursWork = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtInformationDisplay = new System.Windows.Forms.TextBox();
            this.lblInformationDisplay = new System.Windows.Forms.Label();
            this.btnCrtEmployee = new System.Windows.Forms.Button();
            this.btnCrtContractor = new System.Windows.Forms.Button();
            this.btnCalEmTax = new System.Windows.Forms.Button();
            this.btnCalCoTax = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.ComboBox();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.saveFilePath = new System.Windows.Forms.SaveFileDialog();
            this.btnFillRick = new System.Windows.Forms.Button();
            this.btnFillSally = new System.Windows.Forms.Button();
            this.btnFillGreg = new System.Windows.Forms.Button();
            this.btnFillHarry = new System.Windows.Forms.Button();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtCrtEmployeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.title.Location = new System.Drawing.Point(527, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(130, 24);
            this.title.TabIndex = 0;
            this.title.Text = "Tax Calculator";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(274, 201);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(274, 240);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(274, 278);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(274, 323);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(274, 367);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(274, 500);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 6;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // lblHoursWork
            // 
            this.lblHoursWork.AutoSize = true;
            this.lblHoursWork.Location = new System.Drawing.Point(274, 556);
            this.lblHoursWork.Name = "lblHoursWork";
            this.lblHoursWork.Size = new System.Drawing.Size(76, 13);
            this.lblHoursWork.TabIndex = 7;
            this.lblHoursWork.Text = "Hours Worked";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(361, 198);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(247, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(361, 237);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(247, 20);
            this.txtSurname.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(361, 275);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtHoursWork
            // 
            this.txtHoursWork.Location = new System.Drawing.Point(361, 556);
            this.txtHoursWork.Name = "txtHoursWork";
            this.txtHoursWork.Size = new System.Drawing.Size(247, 20);
            this.txtHoursWork.TabIndex = 13;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(361, 497);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(247, 20);
            this.txtEmployeeID.TabIndex = 14;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // txtInformationDisplay
            // 
            this.txtInformationDisplay.Location = new System.Drawing.Point(735, 217);
            this.txtInformationDisplay.Multiline = true;
            this.txtInformationDisplay.Name = "txtInformationDisplay";
            this.txtInformationDisplay.Size = new System.Drawing.Size(353, 380);
            this.txtInformationDisplay.TabIndex = 15;
            // 
            // lblInformationDisplay
            // 
            this.lblInformationDisplay.AutoSize = true;
            this.lblInformationDisplay.Location = new System.Drawing.Point(857, 175);
            this.lblInformationDisplay.Name = "lblInformationDisplay";
            this.lblInformationDisplay.Size = new System.Drawing.Size(96, 13);
            this.lblInformationDisplay.TabIndex = 16;
            this.lblInformationDisplay.Text = "Information Display";
            // 
            // btnCrtEmployee
            // 
            this.btnCrtEmployee.Location = new System.Drawing.Point(65, 163);
            this.btnCrtEmployee.Name = "btnCrtEmployee";
            this.btnCrtEmployee.Size = new System.Drawing.Size(158, 37);
            this.btnCrtEmployee.TabIndex = 17;
            this.btnCrtEmployee.Text = "Create Employee";
            this.btnCrtEmployee.UseVisualStyleBackColor = true;
            this.btnCrtEmployee.Click += new System.EventHandler(this.btnCrtEmployee_Click);
            // 
            // btnCrtContractor
            // 
            this.btnCrtContractor.Location = new System.Drawing.Point(65, 217);
            this.btnCrtContractor.Name = "btnCrtContractor";
            this.btnCrtContractor.Size = new System.Drawing.Size(158, 37);
            this.btnCrtContractor.TabIndex = 18;
            this.btnCrtContractor.Text = "Create Contractor";
            this.btnCrtContractor.UseVisualStyleBackColor = true;
            this.btnCrtContractor.Click += new System.EventHandler(this.btnCrtContractor_Click);
            // 
            // btnCalEmTax
            // 
            this.btnCalEmTax.Location = new System.Drawing.Point(65, 494);
            this.btnCalEmTax.Name = "btnCalEmTax";
            this.btnCalEmTax.Size = new System.Drawing.Size(158, 38);
            this.btnCalEmTax.TabIndex = 19;
            this.btnCalEmTax.Text = "Calculate Employee Tax";
            this.btnCalEmTax.UseVisualStyleBackColor = true;
            this.btnCalEmTax.Click += new System.EventHandler(this.btnCalEmTax_Click);
            // 
            // btnCalCoTax
            // 
            this.btnCalCoTax.Location = new System.Drawing.Point(65, 546);
            this.btnCalCoTax.Name = "btnCalCoTax";
            this.btnCalCoTax.Size = new System.Drawing.Size(158, 38);
            this.btnCalCoTax.TabIndex = 20;
            this.btnCalCoTax.Text = "Calculate Contractor Tax";
            this.btnCalCoTax.UseVisualStyleBackColor = true;
            this.btnCalCoTax.Click += new System.EventHandler(this.btnCalCoTax_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.FormattingEnabled = true;
            this.txtDepartment.Items.AddRange(new object[] {
            "Accounts",
            "Customer Service",
            "IT",
            "Administration",
            " "});
            this.txtDepartment.Location = new System.Drawing.Point(361, 364);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(247, 21);
            this.txtDepartment.TabIndex = 21;
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            " "});
            this.txtGender.Location = new System.Drawing.Point(361, 320);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(247, 21);
            this.txtGender.TabIndex = 22;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(1004, 22);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(158, 37);
            this.btnClearAll.TabIndex = 23;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnFillRick
            // 
            this.btnFillRick.Location = new System.Drawing.Point(12, 278);
            this.btnFillRick.Name = "btnFillRick";
            this.btnFillRick.Size = new System.Drawing.Size(158, 37);
            this.btnFillRick.TabIndex = 24;
            this.btnFillRick.Text = "Quick Fill Rick";
            this.btnFillRick.UseVisualStyleBackColor = true;
            this.btnFillRick.Visible = false;
            this.btnFillRick.Click += new System.EventHandler(this.btnFillRick_Click);
            // 
            // btnFillSally
            // 
            this.btnFillSally.Location = new System.Drawing.Point(12, 321);
            this.btnFillSally.Name = "btnFillSally";
            this.btnFillSally.Size = new System.Drawing.Size(158, 37);
            this.btnFillSally.TabIndex = 25;
            this.btnFillSally.Text = "Quick Fill Sally";
            this.btnFillSally.UseVisualStyleBackColor = true;
            this.btnFillSally.Visible = false;
            this.btnFillSally.Click += new System.EventHandler(this.btnFillSally_Click);
            // 
            // btnFillGreg
            // 
            this.btnFillGreg.Location = new System.Drawing.Point(12, 364);
            this.btnFillGreg.Name = "btnFillGreg";
            this.btnFillGreg.Size = new System.Drawing.Size(158, 37);
            this.btnFillGreg.TabIndex = 26;
            this.btnFillGreg.Text = "Quick Fill Greg";
            this.btnFillGreg.UseVisualStyleBackColor = true;
            this.btnFillGreg.Visible = false;
            this.btnFillGreg.Click += new System.EventHandler(this.btnFillGreg_Click);
            // 
            // btnFillHarry
            // 
            this.btnFillHarry.Location = new System.Drawing.Point(12, 407);
            this.btnFillHarry.Name = "btnFillHarry";
            this.btnFillHarry.Size = new System.Drawing.Size(158, 37);
            this.btnFillHarry.TabIndex = 27;
            this.btnFillHarry.Text = "Quick Fill Harry";
            this.btnFillHarry.UseVisualStyleBackColor = true;
            this.btnFillHarry.Visible = false;
            this.btnFillHarry.Click += new System.EventHandler(this.btnFillHarry_Click);
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(361, 407);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(247, 20);
            this.txtHourlyRate.TabIndex = 28;
            this.txtHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHourlyRate_KeyPress);
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(274, 410);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(87, 13);
            this.lblHourlyRate.TabIndex = 29;
            this.lblHourlyRate.Text = "Hourly Rate      $";
            // 
            // txtCrtEmployeeID
            // 
            this.txtCrtEmployeeID.Location = new System.Drawing.Point(361, 163);
            this.txtCrtEmployeeID.Name = "txtCrtEmployeeID";
            this.txtCrtEmployeeID.Size = new System.Drawing.Size(247, 20);
            this.txtCrtEmployeeID.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Employee ID";
            // 
            // MainPage
            // 
            this.ClientSize = new System.Drawing.Size(1174, 677);
            this.Controls.Add(this.txtCrtEmployeeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.btnFillHarry);
            this.Controls.Add(this.btnFillGreg);
            this.Controls.Add(this.btnFillSally);
            this.Controls.Add(this.btnFillRick);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.btnCalCoTax);
            this.Controls.Add(this.btnCalEmTax);
            this.Controls.Add(this.btnCrtContractor);
            this.Controls.Add(this.btnCrtEmployee);
            this.Controls.Add(this.lblInformationDisplay);
            this.Controls.Add(this.txtInformationDisplay);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.txtHoursWork);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblHoursWork);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.title);
            this.MaximumSize = new System.Drawing.Size(1190, 716);
            this.MinimumSize = new System.Drawing.Size(1190, 716);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Button btnCreateEmployeeForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputEmployeeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox inputDepartment;
        private System.Windows.Forms.TextBox inputFirstName;
        private System.Windows.Forms.TextBox inputSurname;
        private System.Windows.Forms.TextBox inputGender;
        private System.Windows.Forms.TextBox txtDisplayInfo;
        private System.Windows.Forms.Label txtHoursWorked;
        private System.Windows.Forms.TextBox inputHoursWorked;
        private System.Windows.Forms.Label informationDisplay;
        private System.Windows.Forms.Label taxCalculator;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblHoursWork;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoursWork;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtInformationDisplay;
        private System.Windows.Forms.Label lblInformationDisplay;
        private System.Windows.Forms.Button btnCrtEmployee;
        private System.Windows.Forms.Button btnCrtContractor;
        private System.Windows.Forms.Button btnCalEmTax;
        private System.Windows.Forms.Button btnCalCoTax;
        private System.Windows.Forms.ComboBox txtDepartment;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.SaveFileDialog saveFilePath;
        private System.Windows.Forms.Button btnFillRick;
        private System.Windows.Forms.Button btnFillSally;
        private System.Windows.Forms.Button btnFillGreg;
        private System.Windows.Forms.Button btnFillHarry;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox txtCrtEmployeeID;
        private System.Windows.Forms.Label label1;
    }
}

