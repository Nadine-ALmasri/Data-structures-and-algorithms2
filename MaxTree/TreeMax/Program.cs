namespace TreeMax
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(30);
            root.Left = new Node(50);
            root.Right = new Node(100);
            root.Left.Left = new Node(20);
            root.Left.Right = new Node(40);
            root.Right.Left = new Node(60);
            root.Right.Right = new Node(70);

            BinaryTree tree = new BinaryTree();
            tree.root = root;

            // Find the maximum value in the tree
            int maxValue = tree.FindMax();

            Console.WriteLine("Maximum value in the tree: " + maxValue);
        }
    }
}