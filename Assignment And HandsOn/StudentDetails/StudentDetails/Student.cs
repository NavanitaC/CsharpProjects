using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class Student
    {
        public int rollNo;
        public string name;
        public string courseJoined;
        public double feePaidSoFar;

        public static double servicetax = 0.123;

        public Student(int rollNo, string name, string courseJoined, double feePaidSoFar)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.courseJoined = courseJoined;
            this.feePaidSoFar = feePaidSoFar;
        }

        public void Payment(double amount)
        {
            amount = feePaidSoFar + DueAmount;
        }

        public void print()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Roll No: {0}", rollNo);
            Console.WriteLine("Course joined: {0}", courseJoined);
            Console.WriteLine("Total fee: {0}", TotalFee);
            Console.WriteLine("Fee paid so far: {0}", feePaidSoFar);
            Console.WriteLine("Due Amount: {0}", DueAmount);
        }

        public double DueAmount
        {
            get
            {
                return TotalFee - feePaidSoFar;
            }
        }
        public double TotalFee
        {
            get
            {
                  if (courseJoined.ToLower() == "c#")
                    return 2000+(2000*servicetax);
                  else if (courseJoined.ToLower() == "asp.net")
                    return 3000+(3000*servicetax);
                return 0;
                // double total= courseJoined == "C#"?2000:3000;
            }
        }

        public static double ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
            
        }
    }
}
