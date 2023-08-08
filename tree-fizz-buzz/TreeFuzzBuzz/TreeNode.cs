


namespace TreeFuzzBuzz
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> items { get; set; }

        public TreeNode(T value)
        {
            Value = value;
           items = new List<TreeNode<T>>();
        }
    }
}
