//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EmployeesChp11
//{
//    class PayrollSystemTest
//    {
//        static void Main()
//        {
//            // Create derived-class objects
//            var salariedEmployee = new SalariedEmployee("T'Pol", "of Vulcan",
//                "111-11-1111", 800.00M);
//            var hourlyEmployee = new HourlyEmployee("Seven", "of Nine",
//                "222-22-2222", 16.75M, 40.0M);
//            var commissionEmployee = new CommissionEmployee("Six", "of Galactica",
//                "333-33-3333", 10000.00M, 0.06M);
//            var basePlusCommissionEmployee = new BasePlusCommissionEmployee("Deanna", "Troy",
//                "444-44-4444", 5000.00M, 0.04M, 300.00M);

//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine("Employees processed individually:\n");
//            Console.ResetColor();

//            Console.WriteLine($"{salariedEmployee}\nearned: " +
//                $"{salariedEmployee.Earnings():C}\n");
//            Console.WriteLine($"{hourlyEmployee}\nearned: " +
//                $"{hourlyEmployee.Earnings():C}\n");
//            Console.WriteLine($"{commissionEmployee}\nearned: " +
//                $"{commissionEmployee.Earnings():C}\n");
//            Console.WriteLine($"{basePlusCommissionEmployee}\nearned: " +
//                $"{basePlusCommissionEmployee.Earnings():C}\n");

//            // Create List<Employee> and initialize with employee objects
//            var employees = new List<Employee>() { salariedEmployee,
//            hourlyEmployee, commissionEmployee, basePlusCommissionEmployee};

//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine("Employees processed polymorphically:\n");
//            Console.ResetColor();

//            // Generically process each element in employees
//            foreach(var currentEmployee in employees)
//            {
//                Console.WriteLine(currentEmployee);  // Invokes  ToString

//                // Determine whether element is a BasePlusCommissionEmployee
//                if (currentEmployee is BasePlusCommissionEmployee)
//                {
//                    // Downcast Employee reference to BasePlusCommissionEmployee reference
//                    //var employee = (BasePlusCommissionEmployee)currentEmployee;
//                    var employee = currentEmployee as BasePlusCommissionEmployee; // OR INSTEAD OF THE ABOVE, DO THIS

//                    employee.BaseSalary *= 1.10M;
//                    Console.WriteLine("New base salary with 10% increase is: " +
//                        $"{employee.BaseSalary:C}");
//                }

//                Console.WriteLine($"Earned: {currentEmployee.Earnings():C}\n");
//            }

//            // Get type name of each object in employees
//            for (int j = 0; j < employees.Count;  j++)
//            {
//                Console.WriteLine(
//                    $"Employee {j} is a {employees[j].GetType()}");
//            }
//        }
//    }
//}
