using System;
using System.Collections;

namespace BinaryTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree("ABCDE#F");
            binaryTree.PreOrder(binaryTree.Head);
            Console.WriteLine();
            binaryTree.MidOrder(binaryTree.Head);
            Console.WriteLine();
            binaryTree.AfterOrder(binaryTree.Head);
            Console.WriteLine();
            binaryTree.LevelOrder();
            Console.Read();
        }
    }

    public class TreeNode
    {
        public object Data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(object data)
        {
            Data = data;
        }
    }

    public class BinaryTree
    {
        public TreeNode Head { get; set; }
        public string ConstructStr { get; set; }

        public BinaryTree(string str)
        {
            ConstructStr = str;
            Head = new TreeNode(ConstructStr[0]);
            Add(Head, 0);
        }

        private void Add(TreeNode parent, int index)
        {
            int leftIndex = 2 * index + 1;
            if (leftIndex < ConstructStr.Length)
            {
                if (ConstructStr[leftIndex] != '#')
                {
                    parent.Left = new TreeNode(ConstructStr[leftIndex]);
                    Add(parent.Left, leftIndex);
                }
            }
            int rightIndex = 2 * index + 2;
            if (rightIndex < ConstructStr.Length)
            {
                if (ConstructStr[rightIndex] != '#')
                {
                    parent.Right = new TreeNode(ConstructStr[rightIndex]);
                    Add(parent.Right, rightIndex);
                }
            }
        }

        public void PreOrder(TreeNode node)
        {
            if (node != null)
            {
                Console.Write(node.Data);
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        public void MidOrder(TreeNode node)
        {
            if (node != null)
            {
                MidOrder(node.Left);
                Console.Write(node.Data);
                MidOrder(node.Right);
            }
        }

        public void AfterOrder(TreeNode node)
        {
            if (node != null)
            {
                AfterOrder(node.Left);
                AfterOrder(node.Right);
                Console.Write(node.Data);
            }
        }

        public void LevelOrder()
        {
            Queue queue = new Queue();
            queue.Enqueue(Head);
            while (queue.Count > 0)
            {
                TreeNode node = (TreeNode)queue.Dequeue();
                Console.Write(node.Data);
                if (node.Left != null) queue.Enqueue(node.Left);
                if (node.Right != null) queue.Enqueue(node.Right);
            }
        }
    }
}
