using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedImplementation
{
    public class LinkedList
    {
        private class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
            public Node(int value)
            {
                this.Value = value;
            }
        }
        private Node First { get; set; }
        private Node Last { get; set; }
        private int size { get; set; } = 0;

        /// <summary>
        /// To check it the list is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return First == null;
        }
        /// <summary>
        /// To add the item at first
        /// </summary>
        /// <param name="item"></param>
        public void AddFirst(int item)
        {
            var node = new Node(item);
            if (this.IsEmpty())
            {
                First = Last = node;
            }
            else
            {
                node.Next = First;
                First = node;
            }
            size++;
        }

        /// <summary>
        /// Adding the item at last
        /// </summary>
        /// <param name="item"></param>
        public void AddLast(int item)
        {
            var node = new Node(item);
            if (this.IsEmpty())
            {
                First = Last = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }
            size++;
        }

        /// <summary>
        /// To print all the elements inside a linked list
        /// </summary>
        public void Print()
        {
            if (this.IsEmpty()) return;

            var data = First;
            while (data != null)
            {
                Console.WriteLine(data.Value);
                data = data.Next;
            }
        }

        /// <summary>
        /// To get the index of item in list
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int IndexOf(int item)
        {
            int index = 0;
            if (this.IsEmpty()) return -1;

            var currentNode = First;
            while (currentNode != null)
            {
                if (currentNode.Value == item) return index;
                currentNode = currentNode.Next;
                index++;
            }

            
            return -1;
        }

        /// <summary>
        /// To check weather an item is existed or not
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }

        /// <summary>
        /// To remove the node from first index in list
        /// </summary>
        public void RemoveFirst()
        {
            if (this.IsEmpty()) return;

            if (First == Last) { First = Last = null; return; }

            var second = First.Next;
            First.Next = null;
            First = second;
            size--;
        }

        /// <summary>
        /// To get the previous node respect to the given node
        /// </summary>
        /// <returns>Previous node</returns>
        private Node GetPreviousNode(Node node)
        {
            if (this.IsEmpty()) return null;
            var currentNode = First;
            while (currentNode != null)
            {
                if (currentNode.Next == node) return currentNode;
                currentNode = currentNode.Next;
            }
            return null;
        }

        /// <summary>
        /// To remove the last node from the linked list
        /// </summary>
        public void RemoveLast()
        {
            if (this.IsEmpty()) return;
            if (First == Last) { First = Last = null; return; }

            var previousLast = this.GetPreviousNode(Last);
            if (previousLast == null) return;
            Last = previousLast;
            Last.Next = null;
            size--;
        }


        /// <summary>
        /// To get the size of the linked list
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return size;
        }

        /// <summary>
        /// To get the linked list as array
        /// </summary>
        /// <returns></returns>
        public int[] ToArray()
        {
            if (this.IsEmpty()) return new int[0];

            int[] array = new int[size];
            int counter =0;
            var currentNode = First;
            while (currentNode != null)
            {
                array[counter++] = currentNode.Value;
                currentNode = currentNode.Next;
            }
            return array;
        }

        /// <summary>
        /// To get the linked list as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (this.IsEmpty()) return string.Empty;

            var str = new StringBuilder();
            var currentNode = First;
            while (currentNode != null)
            {
                str.Append(currentNode.Value.ToString()+" ");
                currentNode = currentNode.Next;
            }
            return str.ToString();
        }
    }
}
