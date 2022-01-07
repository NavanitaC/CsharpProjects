using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] arr = new int[3];
                int i,n=3;
                Console.WriteLine("Read and Print elements of an array:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Input 10 elements in the array :");
                for (i = 0; i < n; i++)
                {
                    Console.Write("elements - {0} : ", arr[i]);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Elements in array are: ");
                for (i = n; i >0; i--)
                {
                    Console.Write("{0} ", arr[i]);
                }
            Console.ReadLine();
            
        }
    }

}
    

