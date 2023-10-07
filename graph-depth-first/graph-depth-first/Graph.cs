using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_depth_first
{
    public class Graph
    {
        private Dictionary<int, List<int>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        public void AddNode(int node)
        {
            if (!adjacencyList.ContainsKey(node))
            {
                adjacencyList[node] = new List<int>();
            }
        }

        public void AddEdge(int source, int destination)
        {
            if (adjacencyList.ContainsKey(source) && adjacencyList.ContainsKey(destination))
            {
                adjacencyList[source].Add(destination);
            
            }
        }

        public List<int> DepthFirst(int startNode)
        {
            List<int> result = new List<int>();
            HashSet<int> visited = new HashSet<int>();
            DepthFirstHelper(startNode, visited, result);
            return result;
        }

        private void DepthFirstHelper(int node, HashSet<int> visited, List<int> result)
        {
            if (!visited.Contains(node))
            {
                visited.Add(node);
                result.Add(node);

                if (adjacencyList.ContainsKey(node))
                {
                    foreach (var neighbor in adjacencyList[node])
                    {
                        DepthFirstHelper(neighbor, visited, result);
                    }
                }
            }
        }
    }
}
        
