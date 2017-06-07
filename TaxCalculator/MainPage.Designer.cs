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
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtHoursWork = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtInformationDisplay = new System.Windows.Forms.TextBox();
            this.lblInformationDisplay = new System.Windows.Forms.Label();
            this.btnCrtEmployee = new System.Windows.Forms.Button();
            this.btnCrtContractor = new System.Windows.Forms.Button();
            this.btnCalEmTax = new System.Windows.Forms.Button();
            this.btnCalCoTax = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(410, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(198, 32);
            this.title.TabIndex = 0;
            this.title.Text = "Tax Calculator";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(275, 68);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(152, 32);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(275, 134);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(130, 32);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(275, 194);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 32);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(275, 254);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(110, 32);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(275, 314);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(163, 32);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(274, 426);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(176, 32);
            this.lblEmployeeID.TabIndex = 6;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // lblHoursWork
            // 
            this.lblHoursWork.AutoSize = true;
            this.lblHoursWork.Location = new System.Drawing.Point(274, 482);
            this.lblHoursWork.Name = "lblHoursWork";
            this.lblHoursWork.Size = new System.Drawing.Size(194, 32);
            this.lblHoursWork.TabIndex = 7;
            this.lblHoursWork.Text = "Hours Worked";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(361, 68);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(247, 38);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(361, 128);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(247, 38);
            this.txtSurname.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(361, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 38);
            this.txtEmail.TabIndex = 10;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(361, 248);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(247, 38);
            this.txtGender.TabIndex = 11;
            // 
            // txtHoursWork
            // 
            this.txtHoursWork.Location = new System.Drawing.Point(361, 476);
            this.txtHoursWork.Name = "txtHoursWork";
            this.txtHoursWork.Size = new System.Drawing.Size(247, 38);
            this.txtHoursWork.TabIndex = 13;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(361, 416);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(247, 38);
            this.txtEmployeeID.TabIndex = 14;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // txtInformationDisplay
            // 
            this.txtInformationDisplay.Location = new System.Drawing.Point(756, 134);
            this.txtInformationDisplay.Multiline = true;
            this.txtInformationDisplay.Name = "txtInformationDisplay";
            this.txtInformationDisplay.Size = new System.Drawing.Size(353, 380);
            this.txtInformationDisplay.TabIndex = 15;
            // 
            // lblInformationDisplay
            // 
            this.lblInformationDisplay.AutoSize = true;
            this.lblInformationDisplay.Location = new System.Drawing.Point(799, 78);
            this.lblInformationDisplay.Name = "lblInformationDisplay";
            this.lblInformationDisplay.Size = new System.Drawing.Size(258, 32);
            this.lblInformationDisplay.TabIndex = 16;
            this.lblInformationDisplay.Text = "Information Display";
            // 
            // btnCrtEmployee
            // 
            this.btnCrtEmployee.Location = new System.Drawing.Point(65, 134);
            this.btnCrtEmployee.Name = "btnCrtEmployee";
            this.btnCrtEmployee.Size = new System.Drawing.Size(158, 37);
            this.btnCrtEmployee.TabIndex = 17;
            this.btnCrtEmployee.Text = "Create Employee";
            this.btnCrtEmployee.UseVisualStyleBackColor = true;
            this.btnCrtEmployee.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCrtContractor
            // 
            this.btnCrtContractor.Location = new System.Drawing.Point(65, 188);
            this.btnCrtContractor.Name = "btnCrtContractor";
            this.btnCrtContractor.Size = new System.Drawing.Size(158, 37);
            this.btnCrtContractor.TabIndex = 18;
            this.btnCrtContractor.Text = "Create Contractor";
            this.btnCrtContractor.UseVisualStyleBackColor = true;
            // 
            // btnCalEmTax
            // 
            this.btnCalEmTax.Location = new System.Drawing.Point(39, 426);
            this.btnCalEmTax.Name = "btnCalEmTax";
            this.btnCalEmTax.Size = new System.Drawing.Size(203, 38);
            this.btnCalEmTax.TabIndex = 19;
            this.btnCalEmTax.Text = "Calculate Employee Tax";
            this.btnCalEmTax.UseVisualStyleBackColor = true;
            // 
            // btnCalCoTax
            // 
            this.btnCalCoTax.Location = new System.Drawing.Point(39, 478);
            this.btnCalCoTax.Name = "btnCalCoTax";
            this.btnCalCoTax.Size = new System.Drawing.Size(203, 38);
            this.btnCalCoTax.TabIndex = 20;
            this.btnCalCoTax.Text = "Calculate Contractor Tax";
            this.btnCalCoTax.UseVisualStyleBackColor = true;
            // 
            // txtDepartment
            // 
            this.txtDepartment.FormattingEnabled = true;
            this.txtDepartment.Items.AddRange(new object[] {
            "Accounts",
            "Customer Service",
            "IT",
            "Administtration"});
            this.txtDepartment.Location = new System.Drawing.Point(361, 308);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(247, 39);
            this.txtDepartment.TabIndex = 21;
            // 
            // MainPage
            // 
            this.ClientSize = new System.Drawing.Size(1158, 628);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.btnCalCoTax);
            this.Controls.Add(this.btnCalEmTax);
            this.Controls.Add(this.btnCrtContractor);
            this.Controls.Add(this.btnCrtEmployee);
            this.Controls.Add(this.lblInformationDisplay);
            this.Controls.Add(this.txtInformationDisplay);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.txtHoursWork);
            this.Controls.Add(this.txtGender);
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
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtHoursWork;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtInformationDisplay;
        private System.Windows.Forms.Label lblInformationDisplay;
        private System.Windows.Forms.Button btnCrtEmployee;
        private System.Windows.Forms.Button btnCrtContractor;
        private System.Windows.Forms.Button btnCalEmTax;
        private System.Windows.Forms.Button btnCalCoTax;
        private System.Windows.Forms.ComboBox txtDepartment;
    }
}

