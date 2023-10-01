using static Graph.Graphs;

namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graphs();
            var vertex1 = graph.AddVertex("A");
            var vertex2 = graph.AddVertex("B");
            var vertex3 = graph.AddVertex("c");
            graph.AddEdge(vertex1, vertex2);
            graph.AddEdge(vertex1, vertex3);
            graph.AddEdge(vertex2, vertex3);
            var neighbors = graph.GetNeighbors(vertex1);
            Console.WriteLine("Vertices:");
            foreach (var vertex in graph.GetVertices())
            {
                Console.WriteLine(vertex.Value);
            }
            // Print the neighbors of vertexA
            Console.WriteLine("\nNeighbors of A:");
            foreach (var edge in graph.GetNeighbors(vertex1))
            {
                Console.WriteLine($"{edge.Vertex.Value} (Weight: {edge.Weight})");
            }

            // Print the size of the graph
            Console.WriteLine($"\nGraph Size: {graph.Size()}");
            
          graph.Print();
        }
    }
}