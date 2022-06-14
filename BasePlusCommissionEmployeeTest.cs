//using System;

//namespace EmployeesChp11
//{
//    class BasePlusCommissionEmployeeTest
//    {
//        static void Main(string[] args)
//        {
//            // Instantiate CommissionEmployee object
//            var employee = new BasePlusCommissionEmployee("T'Pol", "of Vulcan",
//                "333-33-3333", 5000.00M, 0.04M, 300.00M);

//            // Display CommissionEmployee data
//            Console.WriteLine(
//                "Employee information obtained by properties and methods: \n");
//            Console.WriteLine($"First name is {employee.FirstName}");
//            Console.WriteLine($"Last name is {employee.LastName}");
//            Console.WriteLine($"Social security number is {employee.SocialSecurityNumber}");
//            Console.WriteLine($"Gross sales are {employee.GrossSales}");
//            Console.WriteLine($"Commission rate is {employee.CommissionRate:F2}");
//            Console.WriteLine($"Earnings are {employee.Earnings():C}");
//            Console.WriteLine($"Base salary is {employee.BaseSalary:C}");

//            employee.BaseSalary = 1000.00M; // Reset base salary

//            Console.WriteLine("\nUpdated employee information obtained by ToString:\n");
//            Console.WriteLine(employee);
//            Console.WriteLine($"Earnings: {employee.Earnings():C}");
//        }
//    }
//}
