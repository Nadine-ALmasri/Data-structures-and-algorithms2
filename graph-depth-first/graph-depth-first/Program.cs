namespace graph_depth_first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();


            graph.AddNode(5);
            graph.AddNode(7);
            graph.AddNode(9);
            graph.AddNode(10);

            graph.AddEdge(5, 7);
            graph.AddEdge(5, 9);
            graph.AddEdge(7, 10);


            List<int> traversalResult = graph.DepthFirst(5);


            Console.WriteLine("Pre-order Depth-First Traversal:");
            foreach (int node in traversalResult)
            {
                Console.Write(node + " ");
            }
        }
    }
}