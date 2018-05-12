using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeClass411
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private decimal monthlySalary;

        public Employee(string first, string last, decimal salary)
        {
            FirstName = first;
            LastName = last;
            MonthlySalary = salary;
        }


        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            private set
            {
                if (value > 0.0m)
                {
                    monthlySalary = value;
                }
            }

        }

        public void GiveRaise()
        {
            MonthlySalary = MonthlySalary * 1.10m;
        }

        public decimal GetYearlySalary()
        {
            return MonthlySalary * 12;
        }
        
    }
}
