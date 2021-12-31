using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    class HandsOn6
    {
        static void Main(string[] args)
        {
             int[] arr = new int[] { 3,2,1,5,4};
             int largest = int.MinValue;
             int secondlar = int.MinValue;
             foreach (int i in arr)
             {
                 if (i > largest)
                 {
                     secondlar = largest;
                     largest = i;
                 }
                 else if (i > secondlar)
                     secondlar = i;
             }
             Console.WriteLine(secondlar);
             Console.ReadKey();
        }
    }
}
