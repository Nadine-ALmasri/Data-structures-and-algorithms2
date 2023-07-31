using BinaryTree;
namespace TestTreeS
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void CanInstantiateEmptyTree()
        {
            // Arrange & Act
            var NewTree = new BinarySearch();

            // Assert
            Assert.Null(NewTree.Root);
        }
        [Fact]
        public void TreeWithSingleRootNode()
        {
            // Arrange & Act
            var tree = new BinarySearch();
            tree.Add(30);

            // Assert
            Assert.NotNull(tree.Root);
            Assert.Equal(30, tree.Root.Value);
        }
        [Fact]
        public void LeftAndRightChild()
        {
            // Arrange
            var tree = new BinarySearch();
            tree.Add(50);

            // Act
            tree.Add(20);
            tree.Add(80);

            // Assert
            Assert.NotNull(tree.Root.Left);
            Assert.NotNull(tree.Root.Right);
            Assert.Equal(20, tree.Root.Left.Value);
            Assert.Equal(80, tree.Root.Right.Value);
        }
        [Fact]
        public void PreOrderTraversal()
        {
            // Arrange
            var tree = new BinarySearch();
            tree.Add(50);
            tree.Add(30);
            tree.Add(70);
            tree.Add(20);
            tree.Add(40);
            tree.Add(60);
            tree.Add(80);

            // Act
            var result = tree.PreOrder();

            // Assert
            Assert.Equal(new int[] { 50, 30, 20, 40, 70, 60, 80 }, result);
        }
        [Fact]
        public void InOrderTraversal()
        {
            // Arrange
            var tree = new BinarySearch();
            tree.Add(50);
            tree.Add(30);
            tree.Add(70);
            tree.Add(20);
            tree.Add(40);
            tree.Add(60);
            tree.Add(80);

            // Act
            var result = tree.InOrder();

            // Assert
            Assert.Equal(new int[] { 20, 30, 40, 50, 60, 70, 80 }, result);
        }
        [Fact]
        public void PostOrderTraversal()
        {
            // Arrange
            var tree = new BinarySearch();
            tree.Add(50);
            tree.Add(30);
            tree.Add(70);
            tree.Add(20);
            tree.Add(40);
            tree.Add(60);
            tree.Add(80);

            // Act
            var result = tree.PostOrder();

            // Assert
            Assert.Equal(new int[] { 20, 40, 30, 60, 80, 70, 50 }, result);
        }
        [Fact]
        public void ContainsReturnsTrue()
        {
            // Arrange
            var tree = new BinarySearch();
            tree.Add(20);
            tree.Add(30);
            tree.Add(55);

            // Act & Assert
            Assert.True(tree.Contains(20));
            Assert.True(tree.Contains(55));
        }

        [Fact]
        public void ContainsTestFalse()
        {
            // Arrange
            var tree = new BinarySearch();
            tree.Add(30);
            tree.Add(20);
            tree.Add(70);

            // Act & Assert
            Assert.False(tree.Contains(15));
            Assert.False(tree.Contains(60));
        }
    }
}