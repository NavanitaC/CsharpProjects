using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataCourse d = new PartTimeCourse("C#", 30, 5000,"10-11AM");
            d.Print();
            Console.ReadLine();

            DataCourse p = new OnsiteCourse("ASP.NET", 40, 4000, "Capgemini", 10);
            p.Print();
            Console.ReadLine();
        }
    }
}
