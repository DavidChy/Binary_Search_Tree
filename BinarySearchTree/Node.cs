using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        int data;
        Node left;
        Node right;
        public int Data
        {
            get
            {
                return data;
            }
            set
            {

            }
        }
        public Node Left
        {
            get { return left; }
            set { left = value; }
        }
        public Node Right
        {
            get { return right; }
            set { right = value; }
        }
        public Node(int item)
        {
            data = item;
        }
    }
}
