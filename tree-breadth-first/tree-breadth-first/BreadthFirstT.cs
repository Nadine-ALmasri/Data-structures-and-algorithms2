using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_breadth_first
{
   public class BreadthFirstT
    {
        public List<int> BreadthFirst(Node root)
        {
            List<int> result = new List<int>();

            if (root == null)
                return result;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                   Node current = queue.Dequeue();
                    result.Add(current.Value);

                    if (current.Left != null)
                        queue.Enqueue(current.Left);

                    if (current.Right != null)
                        queue.Enqueue(current.Right);
                }
            }
            return result;
        }
    }
    }

