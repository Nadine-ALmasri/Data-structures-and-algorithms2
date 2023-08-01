using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeMax
{
    public class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            root = null;
        }

        public int FindMax()
        {
            return FindMaxRecursive(root);
        }

        private int FindMaxRecursive(Node node)
        {
            if (node == null)
                return int.MinValue;

            int maxTree = node.Data;
            int leftMax = FindMaxRecursive(node.Left);
            int rightMax = FindMaxRecursive(node.Right);

            maxTree = Math.Max(maxTree, Math.Max(leftMax, rightMax));

            return maxTree;
        }
    }

}
