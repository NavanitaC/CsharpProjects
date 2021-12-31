using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
 	           //access static members  
             Student.DisplayCollegeDetails();
          
            //acess non-static members  
            Console.WriteLine();
            Student s1 = new Student();
            s1.SetStudentDetails("Ram", "MCA");
            s1.DisplayStudentDetails();
            Console.Read();

        }
    }
}
