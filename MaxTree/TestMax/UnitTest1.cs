using TreeMax;
namespace TestMax
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void Test_EmptyTree()
        {
            BinaryTree tree = new BinaryTree();
            int maxValue = tree.FindMax();
            Assert.Equal(int.MinValue, maxValue);
        }
        [Fact]
        public void Test_SingleNode()
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(55);
            int maxValue = tree.FindMax();
            Assert.Equal(55, maxValue);
        }
        [Fact]
        public void Test_FindMax_NegativeValues()
        {
            Node root = new Node(-12);
            root.Left = new Node(-55);
            root.Right = new Node(-15);
            root.Left.Left = new Node(-2);
            root.Left.Right = new Node(-30);

            BinaryTree tree = new BinaryTree();
            tree.root = root;

            int maxValue = tree.FindMax();
            Assert.Equal(-2, maxValue);
        }
        [Fact]
        public void Test_HappyPath()
        {
            Node root = new Node(100);
            root.Left = new Node(300);
            root.Right = new Node(700);
            root.Left.Left = new Node(130);
            root.Left.Right = new Node(152);
            root.Right.Left = new Node(600);
            root.Right.Right = new Node(250);

            BinaryTree tree = new BinaryTree();
            tree.root = root;

            int maxValue = tree.FindMax();
            Assert.Equal(700, maxValue);
        }
    }
}