using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_Algo.Trees
{
    public class BinaryTree
    {
        private class Node
        {
            public int Value { get; set; }
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }

            public Node(int item) { this.Value = item; }
        }
        Node Root { get; set; }

        public bool IsEmpty() { return Root == null; }

        /// <summary>
        /// To insert the new node into a tree
        /// </summary>
        /// <param name="item">Item that we want to insert</param>
        public void Insert(int item)
        {
            var node = new Node(item);
            if (IsEmpty()) {Root = node; return; }

            var current = Root;
            while (true)
            {
                if (current.Value > item)
                {
                    if (current.LeftChild == null) { current.LeftChild = node; break; }
                    current = current.LeftChild;
                }
                else
                {
                    if (current.RightChild == null) { current.RightChild = node; break; }
                    current = current.RightChild;
                }
            }
        }

        /// <summary>
        /// To search an element in a tree
        /// </summary>
        /// <param name="item">Item to search</param>
        /// <returns>True/False</returns>
        public bool Find(int item)
        {
            if (this.IsEmpty()) return false;
            var current = Root;
            while (current!=null)
            {
                if (current.Value == item) return true;
                if (item < current.Value) current = current.LeftChild;
                else current = current.RightChild;
            }
            return false;
        }

        public void TraversePreOrder()
        {
            TraversePreOrder(Root);
        }
        private void TraversePreOrder(Node node)
        {
            if (node == null) return;
            Console.WriteLine(node.Value);
            TraversePreOrder(node.LeftChild);
            TraversePreOrder(node.RightChild);
        }


        public void TraverseInOrder()
        {
            TraverseInOrder(Root);
        }
        private void TraverseInOrder(Node node)
        {
            if (node == null) return;

            TraverseInOrder(node.LeftChild);
            Console.WriteLine(node.Value);
            TraverseInOrder(node.RightChild);
        }
        public void TraversePostOrder()
        {
            TraversePostOrder(Root);
        }

        /// <summary>
        /// To traverse the tree in post order
        /// </summary>
        /// <param name="node">Root node</param>
        private void TraversePostOrder(Node node)
        {
            if (node == null) return;
            TraversePostOrder(node.LeftChild);
            TraversePostOrder(node.RightChild);
            Console.WriteLine(node.Value);
        }

        /// <summary>
        /// To deletect weather a node is leaf or not
        /// </summary>
        /// <param name="node">Node to check</param>
        /// <returns>Tree/False</returns>
        private bool IsLeaf(Node node)
        {
            return node.LeftChild == null && node.RightChild == null;
        }
        public int Height()
        {
            return Height(Root);
        }


        /// <summary>
        /// To calculate the height of the binary tree
        /// </summary>
        /// <param name="node">Root node</param>
        /// <returns>Height of tree</returns>
        private int Height(Node node)
        {
            if (IsLeaf(node)) return 0;
            return 1 + Math.Max(Height(node.LeftChild), Height(node.RightChild));
        }

        public int Min()
        {
            return Min(Root);
        }

        /// <summary>
        /// To get the minimum node from a tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns>Min element</returns>
        private int Min(Node root)
        {
            if (IsLeaf(root)) return root.Value;

            var leftMin = Min(root.LeftChild);
            var rightMin = Min(root.LeftChild);

            return Math.Min(root.Value,Math.Min(leftMin,rightMin));
        }
        public int Max()
        {
            return Max(Root);
        }

        /// <summary>
        /// To get the maximum node from a tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns>Max element</returns>
        private int Max(Node root)
        {
            if (IsLeaf(root)) return root.Value;

            var leftMax = Max(root.LeftChild);
            var rightMax = Max(root.RightChild);

            return Math.Max(root.Value,Math.Max(leftMax,rightMax));
        }

        public bool IsEqual(BinaryTree tree)
        {
            
            return CheckEquality(Root,tree.Root);

        }

        /// <summary>
        /// To check weather two trees are equal or not
        /// </summary>
        /// <param name="root">Current Tree root</param>
        /// <param name="otherRoot">Another tree root</param>
        /// <returns></returns>
        bool CheckEquality(Node root, Node otherRoot)
        {
            if (root == null && otherRoot == null) return true;

            if(root!=null && otherRoot!=null)
            return root.Value == otherRoot.Value && CheckEquality(root.LeftChild, otherRoot.LeftChild)
                && CheckEquality(root.RightChild,otherRoot.RightChild);

            return false;
        }

        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(Root,int.MinValue,int.MaxValue);
        }

        /// <summary>
        /// To swap the childs of the root node
        /// </summary>
        public void SwapRootChild()
        {
            var temp = Root.LeftChild;
            Root.LeftChild = Root.RightChild;
            Root.RightChild = temp;
        }

        /// <summary>
        /// To check waether a tree is binary search tree or not 
        /// </summary>
        /// <param name="root">Root node</param>
        /// <param name="min">Minimum value for that root</param>
        /// <param name="max">Max value for that root</param>
        /// <returns></returns>
        private bool IsBinarySearchTree(Node root,int min,int max)
        {
            if (root==null) return true;

            return root.Value > min && root.Value < max && IsBinarySearchTree(root.LeftChild, min, root.Value)
                && IsBinarySearchTree(root.RightChild, root.Value, max);
        }

        public void NodeAtKDistance(int k)
        {
            //        7
            //    4          9
            //2       6    8    10
            //            
            NodeAtKDistance(Root, k);
        }

        /// <summary>
        /// To display the nodes at k distance | Here we are traversing as pre-order traversel algorithm
        /// </summary>
        /// <param name="root">Current Node</param>
        /// <param name="distance">Distance</param>
        private void NodeAtKDistance(Node root, int distance)
        {
            if (root == null) return;

            if (distance == 0) {
                Console.WriteLine(root.Value);
                return;
            }

            NodeAtKDistance(root.LeftChild,distance-1);
            NodeAtKDistance(root.RightChild, distance - 1);
        }

        /// <summary>
        /// To traverse the tree using BFS algorithm
        /// </summary>
        public void BFSTraversel()
        {
            if (IsEmpty()) return;
            for(int i = 0; i <= Height(); i++)
            {
                NodeAtKDistance(i);
            }
        }
    }
}
