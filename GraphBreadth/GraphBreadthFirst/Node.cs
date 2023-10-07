using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphBreadthFirst
{
    public class Node
    {
        public string Value { get; }
        public List<Node> Neighbors { get; }

        public Node(string value)
        {
            Value = value;
            Neighbors = new List<Node>();
        }
    }
}
