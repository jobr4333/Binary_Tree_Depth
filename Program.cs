using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTree
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        
        public Node()
        {

        }
        public Node(int data)
        {
            this.Data = data;

        }

    }
    public class BinaryTree
    {
        private Node _root;
        public int Depth { get; set; }
        public BinaryTree()
        {
            _root = null;
        }
        public void Insert(int data)
        {
            // 1. If the tree is empty, return a new, single node 
            if (_root == null)
            {
                _root = new Node(data);
                return;
            }
            // 2. Otherwise, recur down the tree 
            InsertRec(_root, new Node(data));
        }
        private void InsertRec(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;

            if (newNode.Data < root.Data)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRec(root.Left, newNode);

            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRec(root.Right, newNode);
            }
        }
        private void DisplayTree(Node root, int depth)
        {
            if (root == null) {

                if (depth > this.Depth)
                {
                    this.Depth = depth;
                }
                return;

            }

            depth++;
            DisplayTree(root.Left, depth);
            
            DisplayTree(root.Right, depth);
            
        }
        public void DisplayTree()
        {
            int depth = 0;
            DisplayTree(_root, depth);
        }

        public void GetDepth()
        {
            Console.WriteLine("depth: " + this.Depth);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Node root = new Node();

            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(5);
            tree.Insert(1);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(5);
            tree.Insert(1);
            tree.Insert(3);
            tree.Insert(5);
            tree.Insert(1);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(5);
            tree.Insert(1);

            tree.DisplayTree();
            tree.GetDepth();
        }
    }
}