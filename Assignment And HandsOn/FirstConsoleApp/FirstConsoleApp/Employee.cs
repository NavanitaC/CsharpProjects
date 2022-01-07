using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Employee
    {
        public string CreateEmployee(string fname, string lname, string email)
        {
            Console.WriteLine("Firstname: " + fname);
            Console.WriteLine("Lastname: " + lname);
            Console.WriteLine("Email: " + email);
            return "Employee details saved successfully";        }
        public void GetEmployee()
        {
            Console.WriteLine("Display employee details");
        }
    }
}
