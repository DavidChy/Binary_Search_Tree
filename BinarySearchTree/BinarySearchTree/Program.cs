using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(10);
            tree.Add(20);
            tree.Add(30);
            tree.Add(40);
            tree.Add(50);
            tree.Add(60);
            tree.Add(70);
            tree.Add(80);
            tree.Add(90);
            tree.Add(100);

            Console.ReadLine();
        }
    }
}
