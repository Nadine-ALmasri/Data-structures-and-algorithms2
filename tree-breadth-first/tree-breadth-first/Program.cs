namespace tree_breadth_first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = new    Node(20);
            root.Left = new Node(10);
            root.Right = new Node(12);
            root.Left.Left = new Node(40);
            root.Left.Right = new   Node(5);
            root.Right.Left = new Node(66);
            root.Right.Right = new Node(70);

            BreadthFirstT bft = new BreadthFirstT();
            List<int> result = bft.BreadthFirst(root);

            Console.WriteLine("The Result Of Breadth-First Traversal: ");
            foreach (int value in result)
            {
                Console.Write(value + " ");
            }
        }
    }
}