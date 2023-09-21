using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_intersection
{
    public class tree_intersections
    {
        public static HashSet<int> TreeIntersectionValues(BinaryTree tree1, BinaryTree tree2)
        {
            HashSet<int> result = new HashSet<int>();
            HashSet<int> valuesInTree1 = new HashSet<int>();

            // Populate the hash set with values from the first tree
            PopulateHashSet(tree1.Root, valuesInTree1);

            // Check values in the second tree against the hash set
            CheckIntersection(tree2.Root, valuesInTree1, result);

            return result;
        }

        private static void PopulateHashSet(Node node, HashSet<int> hashSet)
        {
            if (node == null)
                return;

            hashSet.Add(node.Value);
            PopulateHashSet(node.Left, hashSet);
            PopulateHashSet(node.Right, hashSet);
        }

        private static void CheckIntersection(Node node, HashSet<int> hashSet, HashSet<int> result)
        {
            if (node == null)
                return;

            if (hashSet.Contains(node.Value))
            {
                result.Add(node.Value);
            }

            CheckIntersection(node.Left, hashSet, result);
            CheckIntersection(node.Right, hashSet, result);
        }
    }
}
