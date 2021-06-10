using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_Algo.PriorityQueueImplementation
{
    public class PriorityQueue
    {
        private int[] items;
        private int count = 0;
        public PriorityQueue(int capacity)
        {
            items = new int[capacity];
        }

        public bool IsEmpty()
        {
            return count==0;
        }
        public void Enqueue(int item)
        {
            if(count==items.Length) return;
            int index = count-1;
            while (index>=0 && items[index] > item)
            {
                items[index + 1] = items[index];
                index--;
            }
            items[index+1] = item;
            count++;
        }

        public void PrintQueue()
        {
            int index = 0;
            while (index < count)
            {
                Console.WriteLine(items[index++]);
            }
        }
    }
}
