using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    class PartTimeCourse:DataCourse
    {
        public int discount;
        public string timings;

        public PartTimeCourse(string name, int duration, int fee,string timings): base(name, duration, fee)
        {
            this.timings = timings;
            discount = 10;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Timimg: "+timings);
        }
        public override double GetTotalFee()
        {
            var total = fee * duration;
            return total - (total * discount / 100);
        }
    }

    class OnsiteCourse:DataCourse
    {
        public double charge;
        public string company;
        public int numstud;
        public OnsiteCourse(string name, int duration, int fee,string company,int numstud): base(name,duration,fee)
        {
            this.company = company;
            this.numstud = numstud;
            charge = 10;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Company name: "+company);
            Console.WriteLine("Number of students: "+numstud);
        }

        public override double GetTotalFee()
        {
            var total = fee * duration;
            return total + (total * charge / 100);
        }
    }
}
