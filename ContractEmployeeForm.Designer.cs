namespace _2ndLabExamOOP
{
    partial class ContractEmployeeForm
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
            label4 = new Label();
            txtGender = new ComboBox();
            label5 = new Label();
            txtLname = new TextBox();
            label3 = new Label();
            txtMname = new TextBox();
            label2 = new Label();
            txtFname = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtHoursWorked = new TextBox();
            label6 = new Label();
            txtHourlyRate = new TextBox();
            label7 = new Label();
            btnItem5 = new Button();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(dtBday);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtGender);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtLname);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFname);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 292);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Info";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(108, 208);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(305, 71);
            txtAddress.TabIndex = 13;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(6, 208);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Address";
            // 
            // dtBday
            // 
            dtBday.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtBday.Location = new Point(108, 175);
            dtBday.Name = "dtBday";
            dtBday.Size = new Size(305, 27);
            dtBday.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 175);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 10;
            label4.Text = "Birthday";
            // 
            // txtGender
            // 
            txtGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGender.DropDownStyle = ComboBoxStyle.DropDownList;
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female" });
            txtGender.Location = new Point(108, 141);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(305, 28);
            txtGender.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 141);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 8;
            label5.Text = "Gender";
            // 
            // txtLname
            // 
            txtLname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLname.Location = new Point(108, 108);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(305, 27);
            txtLname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 108);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 4;
            label3.Text = "Lastname";
            // 
            // txtMname
            // 
            txtMname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMname.Location = new Point(108, 75);
            txtMname.Name = "txtMname";
            txtMname.Size = new Size(305, 27);
            txtMname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Middlename";
            // 
            // txtFname
            // 
            txtFname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFname.Location = new Point(108, 42);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(305, 27);
            txtFname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Firstname";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtHoursWorked);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtHourlyRate);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(437, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 124);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Payroll";
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHoursWorked.Location = new Point(119, 68);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(195, 27);
            txtHoursWorked.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 71);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 4;
            label6.Text = "Hours Worked";
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHourlyRate.Location = new Point(119, 31);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(195, 27);
            txtHourlyRate.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 34);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 2;
            label7.Text = "Hourly Rate";
            // 
            // btnItem5
            // 
            btnItem5.Location = new Point(437, 184);
            btnItem5.Name = "btnItem5";
            btnItem5.Size = new Size(334, 66);
            btnItem5.TabIndex = 7;
            btnItem5.Text = "Get Salary";
            btnItem5.UseVisualStyleBackColor = true;
            btnItem5.Click += btnItem5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Yellow;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(437, 158);
            label8.Name = "label8";
            label8.Size = new Size(284, 23);
            label8.TabIndex = 8;
            label8.Text = "10 Points for each functioning button";
            // 
            // ContractEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 321);
            Controls.Add(label8);
            Controls.Add(btnItem5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ContractEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contractual Employee";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtAddress;
        private Label lblAddress;
        private DateTimePicker dtBday;
        private Label label4;
        private ComboBox txtGender;
        private Label label5;
        private TextBox txtLname;
        private Label label3;
        private TextBox txtMname;
        private Label label2;
        private TextBox txtFname;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtHoursWorked;
        private Label label6;
        private TextBox txtHourlyRate;
        private Label label7;
        private Button btnItem5;
        private Label label8;
    }
}