using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_Algo.StackUsingLinkedList
{
    public class LinkedStack
    {
        private class Node
        {
            public int Value { get; set; }
            public Node Prev { get; set; }

            public Node(int value)
            {
                this.Value = value;
            }
        }

        private Node Top { get; set; }

        public void Push(int item)
        {
            var node = new Node(item);
            node.Prev = Top;
            Top = node;
        }

        public void Pop()
        {
            Top = Top.Prev;
        }

        public int Peek()
        {
            return Top.Value;
        }
        public void PrintStack()
        {
            var currentNode = Top;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Prev;
            }
        }

    }
}
