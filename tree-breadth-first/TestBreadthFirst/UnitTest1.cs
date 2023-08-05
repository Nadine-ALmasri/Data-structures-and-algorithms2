using tree_breadth_first;

namespace TestBreadthFirst
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void TestBreadthFirstTraversalHappyPath()
        {
            // Arrange
            Node root = new Node(2);
            root.Left = new Node(7);
            root.Right = new Node(5);
            root.Left.Left = new Node(2);
            root.Left.Right = new Node(6);
            root.Right.Left = new Node(9);
            root.Left.Right.Right = new Node(11);
            root.Left.Right.Left = new Node(5);
            root.Right.Left.Left = new Node(4);
            BreadthFirstT breadth= new BreadthFirstT();

            // Act
            List<int> result = breadth.BreadthFirst(root);

            // Assert
            int[] expectedTraversal = {2,7,5,2,6,9,5,11,4 };
            Assert.Equal(expectedTraversal, result);
        }
        [Fact]
        public void TestEmptyTree()
        {
            // Arrange
            Node root = null;

            BreadthFirstT breadth = new BreadthFirstT();

            // Act
            List<int> result = breadth.BreadthFirst(root);

            // Assert
            Assert.Empty(result);
        }
        [Fact]
        public void TestSingleNodeTree()
        {
            // Arrange
            Node root = new Node(2);

            BreadthFirstT breadth = new BreadthFirstT();

            // Act
            List<int> result = breadth.BreadthFirst(root);

            // Assert
            int[] expectedTraversal = { 2 };
            Assert.Equal(expectedTraversal, result);
        }
    }
}