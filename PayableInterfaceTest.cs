using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesChp11
{
    class PayableInterfaceTest
    {
        static void Main()
        {
            var payableObjects = new List<IPayable>() {
                new Invoice("01234", "seat", 2, 375.00M),
                new Invoice("56789", "tire", 4, 79.95M),
                new SalariedEmployee("T'Pol", "of Vulcan", "111-11-1111", 800.00M),
                new SalariedEmployee("Six", "of Galactica", "222-22-2222", 900.00M)};

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Invoices and Employees processed polymorphically:\n");
            Console.ResetColor();

            // Generically process each element in payableObjects
            foreach(var payable in payableObjects)
            {
                // Output payable and its appropriate payment amount
                Console.WriteLine($"{payable}");
                Console.WriteLine($"Payment due: {payable.GetPaymentAmount():C}\n");
            }
        }  
    }
}
