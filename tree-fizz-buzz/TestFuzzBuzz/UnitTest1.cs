
using System.Reflection;
using TreeFuzzBuzz;
namespace TestFuzzBuzz
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void TestWithZero()
        {
            KaryTree<int> tree = new KaryTree<int>(0);

            KaryTree<string> fizzBuzzedTree = Operation.FizzBuzzTree(tree);
            Assert.Equal("FizzBuzz", fizzBuzzedTree.Root.Value);
        }
        [Fact]
        public void TestTreeWithSigleNode()
        {
            KaryTree<int> Tree = new KaryTree<int>(11);

            KaryTree<string> fizzBuzzedTree = Operation.FizzBuzzTree(Tree);
            Assert.Equal("11", fizzBuzzedTree.Root.Value);
        }
        [Fact]
        public void TestAnEmptyTree()// it will consider it as zero 
        {
            KaryTree<int> emptyTree = new KaryTree<int>(default);
            KaryTree<string> fizzBuzzedTree = Operation.FizzBuzzTree(emptyTree);
            Assert.Equal("FizzBuzz", fizzBuzzedTree.Root.Value);
        }

    }
}