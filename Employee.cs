using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesChp11
{
    public abstract class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
    
        // Three-parameter constructor
        public Employee(string firstName, string lastName, 
            string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        // Return string representation of Eployee object, using properties
        public override string ToString() => $"{FirstName} {LastName}\n" +
            $"Social security number: {SocialSecurityNumber}";

        // Abstract method overridden by derived classes
        public abstract decimal Earnings();  // No implementation here
    }
}
