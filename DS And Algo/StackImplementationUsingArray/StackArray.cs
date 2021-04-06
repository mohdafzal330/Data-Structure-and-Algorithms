using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.StackImplementationUsingArray
{
    public class StackArray
    {
        private int[] items;
        private int counter=-1;

        /// <summary>
        /// Constructor to initialize the stack array
        /// </summary>
        /// <param name="capicity"></param>
        public StackArray(int capicity)
        {
            items = new int[capicity];
        }

        //  To push the item into stack
        public void Push(int item)
        {
            if (counter >= items.Length) throw new IndexOutOfRangeException();

            items[++counter] = item;
        }

        //  To pop the item from the stack
        public void Pop()
        {
            items[counter--] = 0;
        }

        //  To return the peek item from stack
        public int Peek()
        {
            if (Size() == 0) return 0;

            return items[counter];

        }

        //  To get the size of stack
        public int Size()
        {
            return counter+1;
        }

        //  To print the stack
        public void PrintStack()
        {
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
