namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an empty tree
        BinarySearch emptyTree = new BinarySearch();

        // Instantiate a tree with a single root node
        BinarySearch singleNodeTree = new BinarySearch();
        singleNodeTree.Add(50);

        // Add nodes to the tree
        BinarySearch binarySearchTree = new BinarySearch();
        binarySearchTree.Add(15);
        binarySearchTree.Add(25);
        binarySearchTree.Add(70);
        binarySearchTree.Add(80);
        binarySearchTree.Add(17);
        binarySearchTree.Add(22);
        binarySearchTree.Add(65);

        // Perform depth-first traversals
        Console.WriteLine("Pre-order traversal: " + string.Join(", ", binarySearchTree.PreOrder()));
        Console.WriteLine("In-order traversal: " + string.Join(", ", binarySearchTree.InOrder()));
        Console.WriteLine("Post-order traversal: " + string.Join(", ", binarySearchTree.PostOrder()));

        // Check if the tree contains certain values
        Console.WriteLine("Contains 40: " + binarySearchTree.Contains(40)); // should return false
        Console.WriteLine("Contains 65: " + binarySearchTree.Contains(65)); // should return true
    }
    }
}