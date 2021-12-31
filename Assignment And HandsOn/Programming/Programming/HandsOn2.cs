using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    class HandsOn2
    {
       static void Main(string[] args)
        {
            Console.Write("Enter a String: ");
            string orgString = Console.ReadLine();
            string revString = string.Empty;
            for(int i=orgString.Length-1;i>=0;i--)
            {
                revString = revString + orgString[i];
            }
            Console.WriteLine($"Reverse String is: {revString}");
            Console.ReadLine();
        }
    }
}
