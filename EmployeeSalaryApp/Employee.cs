using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Employee
    {
        public string Name { set; get; }
        public double Basic { set; get; }
        public double HouseRent { set; get; }
        public double MedicalAllowance { set; get; }

        public double GetSalary()
        {
            double houseRent = (Basic*HouseRent)/100;
            double medicalAllowance = (Basic*MedicalAllowance)/100;

            return Basic + houseRent + medicalAllowance;

        }

    }
}
