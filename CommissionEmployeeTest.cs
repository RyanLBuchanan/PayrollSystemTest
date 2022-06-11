using System;

namespace EmployeesChp11
{
    class CommissionEmployeeTest
    {
        static void Main(string[] args)
        {
            // Instantiate CommissionEmployee object
            var employee = new CommissionEmployee("Seven", "of Nine",
                "777-77-7777", 7000.00M, 0.07M);

            // Display CommissionEmployee data
            Console.WriteLine(
                "Employee information obtained by properties and methods: \n");
            Console.WriteLine($"First name is {employee.FirstName}");
            Console.WriteLine($"Last name is {employee.LastName}");
            Console.WriteLine($"Social security number is {employee.SocialSecurityNumber}");
            Console.WriteLine($"Gross sales are {employee.GrossSales}");
            Console.WriteLine($"Commission rate is {employee.CommissionRate:F2}");
            Console.WriteLine($"Earnings are {employee.Earnings():C}");

            employee.GrossSales = 7000000.00M;  // Update gross sales
            employee.CommissionRate = 0.70M; // Update commission rate

            Console.WriteLine("\nUpdated employee information obtained by ToString:\n");
            Console.WriteLine(employee);
            Console.WriteLine($"Earnings: {employee.Earnings():C}");
        }
    }
}
