using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_intersection
{
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int value)
        {
            Root = Insertion(Root, value);
        }

       public Node Insertion(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }

            if (value < root.Value)
            {
                root.Left = Insertion(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = Insertion(root.Right, value);
            }

            return root;
        }
    }

}
