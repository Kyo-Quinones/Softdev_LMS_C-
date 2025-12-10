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

namespace _2ndLabExamOOP
{
    public partial class ContractEmployeeForm : Form
    {
        public ContractEmployeeForm()
        {
            InitializeComponent();
        }

        private ContractEmployee LoadEmployee()
        {
            ContractEmployee emp = new ContractEmployee();
            emp.Firstname = txtFname.Text;
            emp.Lastname = txtLname.Text;
            emp.Middlename = txtMname.Text;
            emp.Gender = label5.Text;
            emp.Address = lblAddress.Text;
            emp.Birthdate = dtBday.Value;

            double rate;
            double.TryParse(txtHourlyRate.Text, out rate);
            emp.HourlyRate = rate;

            double hours;
            double.TryParse(txtHoursWorked.Text, out hours);
            emp.HoursWorked = hours;

            return emp;
        }
        private void btnItem5_Click(object sender, EventArgs e)
        {
            //10 Points
            //use MessageBox.Show() to Total Salary here...
            ContractEmployee emp = LoadEmployee();
            MessageBox.Show("Total Salary is " + emp.CalculateSalary());
        }
    }
}
