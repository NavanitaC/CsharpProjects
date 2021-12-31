using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    class Student
    {   
       //non-static data members  
	        public string StudentName;  
	        public string Course;  
	        public void SetStudentDetails(string StuName, string Cou)
	        {  
	            StudentName = StuName;  
	            Course = Cou;  
	        }  
	        public void DisplayStudentDetails()
	        {
			Console.WriteLine("For Non-Static class");
	            Console.WriteLine(StudentName + " - " + Course);  
	        }
	        //static data members  
         public static string CollegeName = "ABC College of Technology";
         public static string CollegeAddress = "Bangalore";

		//static methods  
		public static void DisplayCollegeDetails()
		{
			Console.WriteLine("For Static class");
			Console.WriteLine("College Name is: "+CollegeName);
			Console.WriteLine("College Address is: "+CollegeAddress);
		}
    }
}
