using DS_And_Algo.StackUsingLinkedList;
using DSA.LinkedImplementation;
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
            var linkedList = new LinkedList();

            linkedList.AddLast(50);
            linkedList.AddLast(60);
            linkedList.AddLast(70);
            linkedList.AddLast(80);
            linkedList.AddLast(90);
            linkedList.AddLast(100);
            
            linkedList.Print();
            Console.WriteLine(linkedList.FindMiddleOfLinkedList());


            Console.ReadKey();
        }
    }
}
