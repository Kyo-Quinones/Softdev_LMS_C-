namespace _2ndLabExamOOP
{
    partial class RegularEmployeeForm
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
            groupBox1 = new GroupBox();
            txtAddress = new TextBox();
            lblAddress = new Label();
            dtBday = new DateTimePicker();
            dtBirthday = new Label();
            txtGender = new ComboBox();
            cmdGender = new Label();
            txtLname = new TextBox();
            lblLastname = new Label();
            txtMname = new TextBox();
            llblMiddlename = new Label();
            txtFname = new TextBox();
            lblFirstname = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnItem1 = new Button();
            btnItem2 = new Button();
            btnItem3 = new Button();
            btnItem4 = new Button();
            groupBox2 = new GroupBox();
            chkIsManager = new CheckBox();
            txtMonthlySalary = new TextBox();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(dtBday);
            groupBox1.Controls.Add(dtBirthday);
            groupBox1.Controls.Add(txtGender);
            groupBox1.Controls.Add(cmdGender);
            groupBox1.Controls.Add(txtLname);
            groupBox1.Controls.Add(lblLastname);
            groupBox1.Controls.Add(txtMname);
            groupBox1.Controls.Add(llblMiddlename);
            groupBox1.Controls.Add(txtFname);
            groupBox1.Controls.Add(lblFirstname);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(602, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Info";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(129, 156);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(469, 54);
            txtAddress.TabIndex = 13;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(5, 156);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Address";
            // 
            // dtBday
            // 
            dtBday.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtBday.Location = new Point(129, 131);
            dtBday.Margin = new Padding(3, 2, 3, 2);
            dtBday.Name = "dtBday";
            dtBday.Size = new Size(469, 23);
            dtBday.TabIndex = 11;
            // 
            // dtBirthday
            // 
            dtBirthday.AutoSize = true;
            dtBirthday.Location = new Point(5, 131);
            dtBirthday.Name = "dtBirthday";
            dtBirthday.Size = new Size(51, 15);
            dtBirthday.TabIndex = 10;
            dtBirthday.Text = "Birthday";
            // 
            // txtGender
            // 
            txtGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGender.DropDownStyle = ComboBoxStyle.DropDownList;
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female" });
            txtGender.Location = new Point(129, 106);
            txtGender.Margin = new Padding(3, 2, 3, 2);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(469, 23);
            txtGender.TabIndex = 9;
            // 
            // cmdGender
            // 
            cmdGender.AutoSize = true;
            cmdGender.Location = new Point(5, 106);
            cmdGender.Name = "cmdGender";
            cmdGender.Size = new Size(45, 15);
            cmdGender.TabIndex = 8;
            cmdGender.Text = "Gender";
            // 
            // txtLname
            // 
            txtLname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLname.Location = new Point(129, 81);
            txtLname.Margin = new Padding(3, 2, 3, 2);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(469, 23);
            txtLname.TabIndex = 5;
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(5, 81);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(58, 15);
            lblLastname.TabIndex = 4;
            lblLastname.Text = "Lastname";
            // 
            // txtMname
            // 
            txtMname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMname.Location = new Point(129, 56);
            txtMname.Margin = new Padding(3, 2, 3, 2);
            txtMname.Name = "txtMname";
            txtMname.Size = new Size(469, 23);
            txtMname.TabIndex = 3;
            // 
            // llblMiddlename
            // 
            llblMiddlename.AutoSize = true;
            llblMiddlename.Location = new Point(5, 56);
            llblMiddlename.Name = "llblMiddlename";
            llblMiddlename.Size = new Size(74, 15);
            llblMiddlename.TabIndex = 2;
            llblMiddlename.Text = "Middlename";
            // 
            // txtFname
            // 
            txtFname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFname.Location = new Point(129, 32);
            txtFname.Margin = new Padding(3, 2, 3, 2);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(469, 23);
            txtFname.TabIndex = 1;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(5, 32);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(59, 15);
            lblFirstname.TabIndex = 0;
            lblFirstname.Text = "Firstname";
            // 
            // btnItem1
            // 
            btnItem1.Location = new Point(7, 368);
            btnItem1.Margin = new Padding(3, 2, 3, 2);
            btnItem1.Name = "btnItem1";
            btnItem1.Size = new Size(146, 50);
            btnItem1.TabIndex = 1;
            btnItem1.Text = "Get Full Name";
            btnItem1.UseVisualStyleBackColor = true;
            btnItem1.Click += btnItem1_Click;
            // 
            // btnItem2
            // 
            btnItem2.Location = new Point(158, 368);
            btnItem2.Margin = new Padding(3, 2, 3, 2);
            btnItem2.Name = "btnItem2";
            btnItem2.Size = new Size(146, 50);
            btnItem2.TabIndex = 2;
            btnItem2.Text = "Show Salary";
            btnItem2.UseVisualStyleBackColor = true;
            btnItem2.Click += btnItem2_Click;
            // 
            // btnItem3
            // 
            btnItem3.Location = new Point(310, 368);
            btnItem3.Margin = new Padding(3, 2, 3, 2);
            btnItem3.Name = "btnItem3";
            btnItem3.Size = new Size(146, 50);
            btnItem3.TabIndex = 3;
            btnItem3.Text = "Save to MySQL";
            btnItem3.UseVisualStyleBackColor = true;
            btnItem3.Click += btnItem3_Click;
            // 
            // btnItem4
            // 
            btnItem4.Location = new Point(461, 368);
            btnItem4.Margin = new Padding(3, 2, 3, 2);
            btnItem4.Name = "btnItem4";
            btnItem4.Size = new Size(146, 50);
            btnItem4.TabIndex = 4;
            btnItem4.Text = "Approve Leave";
            btnItem4.UseVisualStyleBackColor = true;
            btnItem4.Click += btnItem4_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(chkIsManager);
            groupBox2.Controls.Add(txtMonthlySalary);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(11, 232);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(601, 76);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Employment Details";
            // 
            // chkIsManager
            // 
            chkIsManager.AutoSize = true;
            chkIsManager.Location = new Point(128, 50);
            chkIsManager.Margin = new Padding(3, 2, 3, 2);
            chkIsManager.Name = "chkIsManager";
            chkIsManager.Size = new Size(73, 19);
            chkIsManager.TabIndex = 5;
            chkIsManager.Text = "Manager";
            chkIsManager.UseVisualStyleBackColor = true;
            chkIsManager.CheckedChanged += chkIsManager_CheckedChanged;
            // 
            // txtMonthlySalary
            // 
            txtMonthlySalary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMonthlySalary.Location = new Point(128, 23);
            txtMonthlySalary.Margin = new Padding(3, 2, 3, 2);
            txtMonthlySalary.Name = "txtMonthlySalary";
            txtMonthlySalary.Size = new Size(469, 23);
            txtMonthlySalary.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 26);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 2;
            label7.Text = "Monthly Salary";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Yellow;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(11, 326);
            label8.Name = "label8";
            label8.Size = new Size(243, 19);
            label8.TabIndex = 6;
            label8.Text = "10 Points for each functioning button";
            // 
            // RegularEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 426);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(btnItem4);
            Controls.Add(btnItem3);
            Controls.Add(btnItem2);
            Controls.Add(btnItem1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegularEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Regular Employee";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMname;
        private Label llblMiddlename;
        private TextBox txtFname;
        private Label lblFirstname;
        private TextBox txtAddress;
        private Label lblAddress;
        private DateTimePicker dtBday;
        private Label dtBirthday;
        private ComboBox txtGender;
        private Label cmdGender;
        private TextBox txtLname;
        private Label lblLastname;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnItem1;
        private Button btnItem2;
        private Button btnItem3;
        private Button btnItem4;
        private GroupBox groupBox2;
        private TextBox txtMonthlySalary;
        private Label label7;
        private CheckBox chkIsManager;
        private Label label8;
    }
}