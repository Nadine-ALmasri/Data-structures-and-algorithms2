using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeFuzzBuzz;

namespace TreeFuzzBuzz; 

public static class Operation
{

public static KaryTree<string> FizzBuzzTree(KaryTree<int> numbers)
    {
        if (numbers.Root == null)
        {
            return new KaryTree<string>(null);
        }
        KaryTree<string> Result = new KaryTree<string>(FizzBuzzValue(numbers.Root.Value));

    FizzBuzzHelper(numbers.Root, Result.Root);

    return Result;
}

private static void FizzBuzzHelper(TreeNode<int> sourceNode, TreeNode<string> targetNode)
{
    foreach (var child in sourceNode.items)
    {
        var fizzBuzzValue = FizzBuzzValue(child.Value);
        var newitemNode = new TreeNode<string>(fizzBuzzValue);
        targetNode.items.Add(newitemNode);

        FizzBuzzHelper(child, newitemNode);
    }
}

private static string FizzBuzzValue(int value)
{
    if (value % 3 == 0 && value % 5 == 0)
        return "FizzBuzz";
    if (value % 3 == 0)
        return "Fizz";
    if (value % 5 == 0)
        return "Buzz";

    return value.ToString();
}
  public  static void Output<T>(TreeNode<T> final)
{
    Console.WriteLine(" " + final.Value);
    foreach (var child in final.items)
    {
        Output(child);
    }
}
}
