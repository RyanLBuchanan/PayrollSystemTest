using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesChp11
{
    public class HourlyEmployee : Employee
    {
        private decimal wage;
        private decimal hours;

        // Five-parameter constructor
        public HourlyEmployee(string firstName, string lastName, 
            string socialSecurityNumber, decimal hourlyWage,
            decimal hoursWorked)
            : base(firstName, lastName, socialSecurityNumber)
        {
            Wage = hourlyWage;  // Validate private instance variable of hourly wage
            Hours = hoursWorked; // Validate private instance variable of hours worked
        }

        // Property that gets sets hourly employee's wage
        public decimal Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Wage)} must be >= 0");
                }

                wage = value;
            }
        }

        // Property that gets sets hourly employee's hours
        public decimal Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value < 0 || value > 168)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Hours)} must be >= 0 and <= 168");
                }

                wage = value;
            }
        }

        // Calculate earnings: override Employee's abstract Earnings method
        public override decimal Earnings()
        {
            if (Hours <= 40) // No overtime
            {
                return Wage * Hours;
            }
            else
            {
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
            }
        }

        // Return string representation of HourlyEmployee object
        public override string ToString() =>
            $"Hourly employee: {base.ToString()}\n" +
            $"Hourly wage: {Wage:C}\nHours worked: {Hours:F2}";
    }
}
