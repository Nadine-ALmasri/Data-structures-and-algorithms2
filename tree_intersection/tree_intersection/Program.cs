namespace tree_intersection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree1 = new BinaryTree();
            tree1.Insert(100);
            tree1.Insert(200);
            tree1.Insert(300);
            tree1.Insert(400);

            BinaryTree tree2 = new BinaryTree();
            tree2.Insert(500);
            tree2.Insert(300);
            tree2.Insert(200);
            tree2.Insert(600);
            HashSet<int> result = tree_intersections.TreeIntersectionValues(tree1, tree2);

            Console.WriteLine("Intersection values: ");
            foreach (int value in result)
            {
                Console.WriteLine(value);
            }
        }
    }
}