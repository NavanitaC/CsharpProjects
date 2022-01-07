using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            Console.WriteLine("Read and Print elements of an array:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Input 10 elements in the array :");
            for(i=0;i<10;i++)
            {
                Console.Write("elements - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Elements in array are: ");
            for(i=0;i<10;i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
