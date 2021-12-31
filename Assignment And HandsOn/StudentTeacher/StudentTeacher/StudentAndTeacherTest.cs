using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Greet();
            Console.ReadLine();

            Student s = new Student();
            s.SetAge(21);
            s.Greet();
            s.ShowAge();
            s.GoToClasses();
            Console.ReadLine();

            Teacher t = new Teacher();
            t.SetAge(30);
            t.Greet();
            t.Explain();
            Console.ReadKey();

           

        }
    }
}
