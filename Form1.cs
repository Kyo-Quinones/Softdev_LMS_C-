using System;
using System.Windows.Forms;

namespace _2ndLabExamOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnItem1_Click(object sender, EventArgs e)
        {
            RegularEmployeeForm frmRegEmp = new RegularEmployeeForm();
            frmRegEmp.Show();
        }

        private void btnItem2_Click(object sender, EventArgs e)
        {
            ContractEmployeeForm frmContractEmp = new ContractEmployeeForm();
            frmContractEmp.Show();
        }
    }
}
