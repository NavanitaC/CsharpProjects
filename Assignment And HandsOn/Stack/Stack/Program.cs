using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(20);

            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Length);

            Console.WriteLine(s.Pop());
        }
    }
}
