using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        Node root = null;
        public BinaryTree()
        {

        }
        public void Add(int item)
        {
            Node node = new Node(item);
            if (root == null)
            {
                root = node;
                return;
            }
            Node current = root;
            while (current != null)
            {
                if (current.Data > node.Data)
                {
                    if (current.Left != null)
                    {
                        current = current.Left;
                        continue;
                    }
                    else if (current.Left == null)
                    {
                        current.Left = node;
                        return;
                    }
                }
                else if (current.Data < node.Data)
                {
                    if (current.Right != null)
                    {
                        current = current.Right;
                        continue;
                    }
                    else if (current.Right == null)
                    {
                        current.Right = node;
                        return;
                    }
                }
            }
        }

        public bool Search(int searchData)
        {
            Node current = root;
            while (current != null)
            {
                if (current.Data.Equals(searchData))
                {
                    Console.WriteLine("Found");
                    return true;
                }
                else if (current.Data > searchData)
                {
                    if (current != null)
                    {
                        current = current.Left;
                        Console.WriteLine("Left");
                        continue;
                    }
                }
                else if (current.Data < searchData)
                {
                    if (current.Right != null)
                    {
                        current = current.Right;
                        Console.WriteLine("Right");
                        return true;
                    }
                }
            }
            Console.WriteLine("Not Found");
            return false;
        }
    }
}