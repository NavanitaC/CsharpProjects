using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    class HandsOn1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String: ");
            string s = Console.ReadLine();
            s = s.Replace(" ",string.Empty);
            while(s.Length > 0)
            {
                Console.Write(s[0] + ":");
                int count = 0;
                for (int i=0;i<s.Length;i++)
                {
                    if(s[0]==s[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                s = s.Replace(s[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}
