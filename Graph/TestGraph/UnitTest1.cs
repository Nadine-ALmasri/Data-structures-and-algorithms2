using Graph;

namespace TestGraph
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void AddVertexToGraph()
        {
            var graph = new Graph.Graphs();
            var vertex = graph.AddVertex("1");
            Assert.Equal("1", vertex.Value);
            Assert.Contains(vertex, graph.GetVertices());
        }

        [Fact]
        public void AddEdgeBetweenVertices()
        {
            var graph = new Graphs();
            var vertex1 = graph.AddVertex("1");
            var vertex2 = graph.AddVertex("2");
            graph.AddEdge(vertex1, vertex2);
            var neighbors = graph.GetNeighbors(vertex1);
         
            Assert.Equal(1, neighbors.Count);
        }

        [Fact]
        public void ReturnAllVertices()
        {
            var graph = new Graphs();
            graph.AddVertex("1");
            graph.AddVertex("2");
            var vertices = graph.GetVertices();
         
            Assert.Equal(2, vertices.Count);
        }

        

        [Fact]
        public void Returnsize()
        {
            var graph = new Graph.Graphs();
            graph.AddVertex("2");
            Assert.Equal(1, graph.Size());
        }
    }

}