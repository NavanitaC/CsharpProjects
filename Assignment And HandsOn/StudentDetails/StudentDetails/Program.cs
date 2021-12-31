using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(123, "Navanita", "C#", 1000);
            Student t = new Student(456, "Jivangi", "ASP.NET", 2000);

            s.Payment(2000);
            t.Payment(3000);

            s.print();
            Console.WriteLine();
            t.print();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
