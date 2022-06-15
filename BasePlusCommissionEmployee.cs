using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesChp11
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary;

        // Six parameter constructor
        public BasePlusCommissionEmployee(string firstName, string lastName,
            string socialSecurityNumber, decimal grossSales, 
            decimal commissionRate, decimal baseSalary) 
            : base(firstName, lastName, socialSecurityNumber, // Refer to base class
                grossSales, commissionRate)
        {
            // Implicit call to object constructor occurs here
            BaseSalary = baseSalary;  // Validates base salary
        }

        // Property that gets and sets commission employee's commission rate
        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value < 0)  // Validation of not less the 0% or higher than 100% or 1.0
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(BaseSalary)} must be greater than or equal to 0");
                }

                baseSalary = value;
            }
        }

        // Calculate earnings
        public override decimal Earnings() => BaseSalary + base.Earnings();

        // Return string representation of CommissionEmployee object
        public override string ToString() =>
            $"Base-salaried {base.ToString()}\nBase salary: {BaseSalary:C}";
    }
}
