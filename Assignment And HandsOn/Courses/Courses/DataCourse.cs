using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    abstract class DataCourse
    {
        public string name;
        public int duration;
        public int fee;

        public DataCourse(string name, int duration, int fee)
        {
            this.name = name;
            this.duration = duration;
            this.fee = fee;
        }
        public virtual void Print()
        {
            Console.WriteLine("Course Name: " + name);
            Console.WriteLine("Course Duration(min): " + duration.ToString());
            Console.WriteLine("Course Fee: " + fee.ToString());
            Console.WriteLine("Total course fee: " + GetTotalFee().ToString());
            Console.ReadKey();
        }
        public abstract double GetTotalFee();
    }
}
