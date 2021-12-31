using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    class HandsOn5
    {   
            static void Main(string[] args)
            {
                Console.Write("Enter a String : ");
                string a = Console.ReadLine();
                Console.WriteLine("substrings are: ");
                for (int i = 0; i < a.Length; i++)
                {
                    StringBuilder subString = new StringBuilder(a.Length - i);
                    for (int j = i; j < a.Length; j++)
                    {
                        subString.Append(a[j]);
                        Console.Write(subString + " ");
                    }
                }
                Console.ReadKey();
            }
    }
}

