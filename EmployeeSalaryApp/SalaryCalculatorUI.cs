using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class SalaryCalculatorUI : Form
    {
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void showmeSalaryButton_Click(object sender, EventArgs e)
        {
            Employee aEmployeeSalary=new Employee();
            aEmployeeSalary.Name = employeeNameTextBox.Text;
            aEmployeeSalary.Basic = Convert.ToDouble(basicamountTextBox.Text);
            aEmployeeSalary.HouseRent = Convert.ToDouble(houseRentTextBox.Text);
            aEmployeeSalary.MedicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            double salary = aEmployeeSalary.GetSalary();
            MessageBox.Show(aEmployeeSalary.Name  + " Your Salary is : " + aEmployeeSalary.GetSalary());
        }
    }
}
