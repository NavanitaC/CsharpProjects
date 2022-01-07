using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)   
        {
            /*  Console.WriteLine("welcome;");
              Console.WriteLine(100);
              Console.WriteLine(100.10);
              Console.WriteLine(true);  */

            Console.Write("Enter firstname: ");
            string fname =Console.ReadLine();
            Console.Write("Enter lastname: ");
            string lname = Console.ReadLine();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Employee employeeObj = new Employee();
            string result= employeeObj.CreateEmployee(fname, lname, email);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

