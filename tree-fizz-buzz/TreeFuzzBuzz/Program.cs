using System;
using System.Reflection;
using System.Xml.Linq;
using TreeFuzzBuzz;

using  TreeFuzzBuzz;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KaryTree<int> Tree = new KaryTree<int>(default);
            var root = Tree.Root;
            root.items.Add(new TreeNode<int>(20));
            root.items.Add(new TreeNode<int>(5));
            root.items.Add(new TreeNode<int>(30));
            KaryTree<string> fizzBuzzedTree = Operation.FizzBuzzTree(Tree);
            //foreach (var child in node.Children)
            // {
            //    Console.WriteLine(originalTree.Root + "");
            Console.WriteLine("Original Tree:");
            Operation.Output(Tree.Root);

            Console.WriteLine("\nFizzBuzzed Tree:");
            Operation.Output(fizzBuzzedTree.Root);
            // }


        }
    }
}