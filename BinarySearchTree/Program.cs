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
            tree.Add(6);
            tree.Add(7);
            tree.Add(5);
            tree.Add(4);
            tree.Add(9);
            

            tree.Search(4);

            Console.ReadLine();
        }
    }
}
