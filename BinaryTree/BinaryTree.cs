using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }

    public BinaryTree()
    {
        Root = null;
    }

    // Depth-first traversal methods
    public List<int> PreOrder()
    {
        List<int> result = new List<int>();
        PreOrderTraversal(Root, result);
        return result;
    }

    private void PreOrderTraversal(Node node, List<int> result)
    {
        if (node == null) return;
        result.Add(node.Value);
        PreOrderTraversal(node.Left, result);
        PreOrderTraversal(node.Right, result);
    }

    public List<int> InOrder()
    {
        List<int> result = new List<int>();
        InOrderTraversal(Root, result);
        return result;
    }

    private void InOrderTraversal(Node node, List<int> result)
    {
        if (node == null) return;
        InOrderTraversal(node.Left, result);
        result.Add(node.Value);
        InOrderTraversal(node.Right, result);
    }

    public List<int> PostOrder()
    {
        List<int> result = new List<int>();
        PostOrderTraversal(Root, result);
        return result;
    }

    private void PostOrderTraversal(Node node, List<int> result)
    {
        if (node == null) return;
        PostOrderTraversal(node.Left, result);
        PostOrderTraversal(node.Right, result);
        result.Add(node.Value);
    }
}

}
