using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesChp11
{
    public class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

        // Four-parameter constructor
        public SalariedEmployee(string firstName, string lastName,
            string socialSecurityNumber, decimal weeklySalary)
            : base(firstName, lastName, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }

        // Property that gets and sets salaried employee's salary
        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(WeeklySalary)} must >= 0");
                }

                weeklySalary = value;
            }
        }

        // Calculate earnings. overrride abstract method Earnings in Employee
        public override decimal Earnings() => WeeklySalary;

        // Return string representation 
        public override string ToString() =>
            $"Salaried employee: {base.ToString()}\n" +
            $"Weekly salary: {WeeklySalary:C}";
    }
}
