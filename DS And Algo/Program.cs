using DSA.StackImplementationUsingArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new StackArray(5);
            var p = stack.Peek();
            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
