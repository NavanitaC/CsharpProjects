using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    class HandsOn3
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the String: ");
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            int k = a.Length - 1;
            n = k;
            for (int i = k; n >= 0; k--)
            { 
                Console.Write(a[n] + "" + ' ');
                --n;
            }
            Console.ReadKey();
        }
    }
}

