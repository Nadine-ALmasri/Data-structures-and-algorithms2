using tree_intersection;
namespace Test_tree_intersection
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void TestEmptyTrees()
        {
            BinaryTree tree1 = new BinaryTree();
            BinaryTree tree2 = new BinaryTree();

            var result = tree_intersections.TreeIntersectionValues(tree1, tree2);

            Assert.Empty(result);
        }

        [Fact]
        public void TestNoCommonValues()
        {
            BinaryTree tree1 = new BinaryTree();
            tree1.Insert(20);
            tree1.Insert(25);
            tree1.Insert(32);

            BinaryTree tree2 = new BinaryTree();
            tree2.Insert(40);
            tree2.Insert(15);
            tree2.Insert(62);

            var result = tree_intersections.TreeIntersectionValues(tree1, tree2);

            Assert.Empty(result);
        }

        [Fact]
        public void TestCommonValues()
        {
            BinaryTree tree1 = new BinaryTree();
            tree1.Insert(20);
            tree1.Insert(25);
            tree1.Insert(31);
            tree1.Insert(43);

            BinaryTree tree2 = new BinaryTree();
            tree2.Insert(31);
            tree2.Insert(43);
            tree2.Insert(15);
            tree2.Insert(16);

            var result = tree_intersections.TreeIntersectionValues(tree1, tree2);

            Assert.Collection(result,
                val => Assert.Equal(31, val),
                val => Assert.Equal(43, val)
            );
        }
    }
}