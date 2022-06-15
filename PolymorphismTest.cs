//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EmployeesChp11
//{
//    class PolymorphismTest
//    {
//        static void Main()
//        {
//            // Assign base-class reference to base-class variable
//            var commissionEmployee = new CommissionEmployee(
//                "Princess", "Pei Pei", "222-22-2222", 10000.00M, 0.06M);

//            // Assign derived-class reference to derived-class variable
//            var basePlusCommissionEmployee = new BasePlusCommissionEmployee(
//                "What-about", "Bob", "333-33-3333", 5000.00M, 0.04M, 300.00M);

//            // Invoke ToString and Earnings on base-class object
//            // using base-class variable
//            Console.WriteLine(
//                "Call CommissionEmployee's ToString and Earnings methods " +
//                "with base-class reference to base class object\n");
//            Console.WriteLine(commissionEmployee.ToString());
//            Console.WriteLine($"Earnings: {commissionEmployee.Earnings()}\n");

//            // Invoke ToString and Earnings on derived-class object
//            // using derived-class variable
//            Console.WriteLine(
//                "Call BasePlusCommissionEmployee's ToString and Earnings methods " +
//                "with derived-class reference to derived-class object\n");
//            Console.WriteLine(basePlusCommissionEmployee.ToString());
//            Console.WriteLine($"Earnings: {basePlusCommissionEmployee.Earnings()}\n");

//            //Invoke ToString and Earnings on derived-class object
//            // using base-class variable
//            CommissionEmployee commissionEmployee2 = basePlusCommissionEmployee;
//            Console.WriteLine(
//                "Call BasePlusCommissionEmployee's ToString and Earnings " +
//                "methods with base-class reference to derived-class object");
//            Console.WriteLine(commissionEmployee2.ToString());
//            Console.WriteLine($"Earnings: {basePlusCommissionEmployee.Earnings()}");
//        }
//    }
//}
