using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2ndLabExamOOP.Models;
using _2ndLabExamOOP.Business;
using _2ndLabExamOOP.Interfaces;
using _2ndLabExamOOP.Data; 

namespace _2ndLabExamOOP
{
    public partial class RegularEmployeeForm : Form
    {
        public RegularEmployeeForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private RegularEmployee LoadEmployee()
        {
            RegularEmployee emp = new RegularEmployee();
            emp.Firstname = txtFname.Text;
            emp.Lastname = txtLname.Text;
            emp.Middlename = txtMname.Text;
            emp.Lastname = txtLname.Text;
            emp.Gender = cmdGender.Text;
            emp.Address = txtAddress.Text;
            emp.Birthdate = dtBday.Value;

            double salary;
            double.TryParse(txtMonthlySalary.Text, out salary);
            emp.MonthlySalary = salary;

            return emp;
        }

        private void chkIsManager_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnItem1_Click(object sender, EventArgs e)
        {
            //10 Points
            //use MessageBox.Show() to display fullname
            RegularEmployee emp = LoadEmployee();
            MessageBox.Show("HELLO! " + emp.GetFullName());
        }

        private void btnItem2_Click(object sender, EventArgs e)
        {
            //10 Points
            //use MessageBox.Show() to display Monthly Salary
            RegularEmployee emp = LoadEmployee();
            MessageBox.Show("Monthly Salary is " + emp.CalculateSalary());
        }

        private void btnItem3_Click(object sender, EventArgs e)
        {
            //10 Points
            //use MessageBox.Show() to display Saving process status
            RegularEmployee emp = LoadEmployee();

            IEmployeeRepository repo = new MySqlRepository();
            EmployeeManager manager = new EmployeeManager(repo);

            bool saved = manager.AddEmployee(emp);
        }

        private void btnItem4_Click(object sender, EventArgs e)
        {
            //10 Points
            //use MessageBox.Show() to display "Leave Approved!"
            if (chkIsManager.Checked)
            {
               ManagerFunctions m = new ManagerFunctions();
                m.ApproveLeave();
            } 
            else
            {
                MessageBox.Show("Only Managers can Leave!");
            }
        }

    }
}
