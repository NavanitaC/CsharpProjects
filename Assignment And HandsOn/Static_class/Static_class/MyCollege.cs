using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_class
{
    class MyCollege
    {
		//static fields  
		public static string CollegeName;
		public static string Address;

		//static constructor  
		static MyCollege()
		{
			CollegeName = "ABC College of Technology";
			Address = "Hyderabad";
		}
	}
}
