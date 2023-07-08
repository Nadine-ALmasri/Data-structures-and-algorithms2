using Zipping;

namespace TestZipper
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void TestForOneEmptyList() {
            ZipList list1 = new ZipList();
          
            ZipList list2 = new ZipList();
            list2.Head = new Node(1);
            list2.Head.Next = new Node(3);
            list2.Head.Next.Next = new Node(5);

            ZipList List3 = ZipList.ZipLists(list1, list2);
            Assert.Equal(List3.Head.Data ,1) ;
            Assert.Equal(List3.Head.Next.Data, 3);
            Assert.Equal(List3.Head.Next.Next.Data, 5);
            Assert.Null(List3.Head.Next.Next.Next);

        }
        [Fact]
        public void TestForTwoEmptyList()
        {
            ZipList list1 = new ZipList();

            ZipList list2 = new ZipList();
         

            ZipList List3 = ZipList.ZipLists(list1, list2);
            Assert.Null(List3.Head);

 

        }
        [Fact]
        public void TestFordiffentLeghthList()
        {
            ZipList list1 = new ZipList();
            list1.Head = new Node(0);
            list1.Head.Next = new Node(2);
            ZipList list2 = new ZipList();
            list2.Head = new Node(1);
            list2.Head.Next = new Node(3);
            list2.Head.Next.Next = new Node(5);

            ZipList List3 = ZipList.ZipLists(list1, list2);
            Assert.Equal(List3.Head.Data, 0);
            Assert.Equal(List3.Head.Next.Data, 1);
            Assert.Equal(List3.Head.Next.Next.Data, 2);
            Assert.Equal(List3.Head.Next.Next.Next.Data , 3);
            Assert.Equal(List3.Head.Next.Next.Next.Next.Data, 5);

        }
        [Fact]
        public void TestForHappyPath()
        {
            ZipList list1 = new ZipList();
            list1.Head = new Node(0);
            list1.Head.Next = new Node(2);
            list1.Head.Next.Next = new Node(4);
            ZipList list2 = new ZipList();
            list2.Head = new Node(1);
            list2.Head.Next = new Node(3);
            list2.Head.Next.Next = new Node(5);

            ZipList List3 = ZipList.ZipLists(list1, list2);
            Assert.Equal(List3.Head.Data, 0);
            Assert.Equal(List3.Head.Next.Data, 1);
            Assert.Equal(List3.Head.Next.Next.Data, 2);
            Assert.Equal(List3.Head.Next.Next.Next.Data, 3);
            Assert.Equal(List3.Head.Next.Next.Next.Next.Data, 4);
            Assert.Equal(List3.Head.Next.Next.Next.Next.Next.Data, 5);

        }
    }
}