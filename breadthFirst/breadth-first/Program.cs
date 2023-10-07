namespace breadth_first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node pandora = new Node("Pandora");
            Node arendelle = new Node("Arendelle");
            Node metroville = new Node("Metroville");
            Node monstroplolis = new Node("Monstroplolis");
            Node narnia = new Node("Narnia");
            Node naboo = new Node("Naboo");

            pandora.Neighbors.Add(arendelle);
            arendelle.Neighbors.Add(pandora);
            arendelle.Neighbors.Add(metroville);
            metroville.Neighbors.Add(arendelle);
            metroville.Neighbors.Add(monstroplolis);
            monstroplolis.Neighbors.Add(metroville);
            monstroplolis.Neighbors.Add(narnia);
            narnia.Neighbors.Add(monstroplolis);
            narnia.Neighbors.Add(naboo);
            naboo.Neighbors.Add(narnia);

            Graph graph = new Graph(pandora);

            List<Node> bfsResult = graph.BreadthFirst(pandora);
            string resultString = string.Join(", ", bfsResult.Select(node => node.Value));
            Console.WriteLine("Output:\n" + resultString);
        }
    }
}