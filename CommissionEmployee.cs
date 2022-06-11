using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesChp11
{
    public class CommissionEmployee : object
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
        private decimal grossSales;
        private decimal commissionRate;

        // Five parameter constructor
        public CommissionEmployee(string firstName, string lastName, 
            string socialSecurityNumber, decimal grossSales, decimal commissionRate)
        {
            // Implicit call to object constructor occurs here
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            GrossSales = grossSales; // Validates gross sales
            CommissionRate = commissionRate; // Validates commission rate
        }

        // Property that gets and sets commission employee's gross sales
        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value < 0 ) // Validation -- the "check for this so and so
                {
                    throw new ArgumentOutOfRangeException(nameof(value), 
                        value, $"{nameof(GrossSales)} must be >= 0");
                }

                grossSales = value;
            }
        }

        // Property that gets and sets commission employee's commission rate
        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value <= 0 || value >= 1)  // Validation of not less the 0% or higher than 100% or 1.0
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(CommissionRate)} must be greater than 0 and less than 1");
                }

                commissionRate = value;
            }
        }

        // Calculate commission employee's pay
        public decimal Earnings() => commissionRate * grossSales;

        // Return string representation of CommissionEmployee object
        public override string ToString() =>
            $"Commission employee:  {FirstName} {LastName}\n" +
            $"Social security number: {SocialSecurityNumber}\n" +
            $"Gross sales: {GrossSales:C}\n" +
            $"Commission rate: {CommissionRate:F2}";
    }
}
