using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node root;
        public BinaryTree()
        {
            root = null;
        }

        public Node Root
        {
            get { return root; }
            set { root = value; }
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (root == null)
            {
                this.root = newNode;
            }
            else
            {
                Node current = root;
                while (true)
                {
                    Node parent = current;
                    if (parent.data < data)
                    {
                        current = current.rightChild;
                        if (current == null)
                        {
                            parent.rightChild = newNode;
                            return;
                        }

                    }
                    else if (parent.data > data)
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public void Search(int data)
        {
            if (root == null)
            {
                Console.WriteLine("There is not a tree to search.");
            }
            else
            {
                Node current = root;
                while (true)
                {
                    Node parent = current;
                    if (parent.data < data)
                    {
                        current = current.rightChild;
                        if (current == null)
                        {
                            Console.WriteLine(data + " is not in the tree.");
                            return;
                        }
                        else if (current.data == data)
                        {
                            Console.WriteLine("The tree contains " + data + ".");
                            return;
                        }
                    }
                    else if (parent.data > data)
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            Console.WriteLine(data + " is not in the tree.");
                            return;
                        }
                        else if (current.data == data)
                        {
                            Console.WriteLine("The tree contains " + data + ".");
                            return;
                        }
                    }
                }
            }
        }
    }
}