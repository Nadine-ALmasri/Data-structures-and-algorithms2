using LinkedList;

namespace linkedTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }


 
        [Fact]
        public void InstantiateEmptyLinkedList()
        {
            // Arrange
         List linkedList = new List();

            // Assert
            Assert.Equal(linkedList.Head , null);
        }

        [Fact]
        public void InsertsIntoLinkedList_Success()
        {
            // Arrange
      List List2 = new List();

            // Act
            List2.Insert(2);

            // Assert
            Assert.NotNull(List2.Head);
            Assert.Equal(2, List2.Head.Data);
            Assert.Null(List2.Head.Next);
        }

        [Fact]
        public void MultipleNodesInserted()
        {
            // Arrange
           List List3 = new List();

            // Act
          List3.Insert(3);
            List3.Insert(2);
         List3.Insert(1);

            // Assert
            Assert.Equal(1,List3.Head.Data);
            Assert.Equal(2, List3.Head.Next.Data);
            Assert.Equal(3, List3.Head.Next.Next.Data);
            Assert.Null(List3.Head.Next.Next.Next);
        }

        [Fact]
        public void FindsExistingValue()
        {
            // Arrange
        List linkedList = new List();
            linkedList.Insert(30);
            linkedList.Insert(22);
            linkedList.Insert(10);

            // Act
            bool result = linkedList.includes(22);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void DoesNotFindNonExistingValue()
        {
            // Arrange
         List linkedList3 = new List();
            linkedList3.Insert(3);
            linkedList3.Insert(2);
            linkedList3.Insert(1);

            // Act
            bool result = linkedList3.includes(4);

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(4 ,false)]
        [InlineData(3 ,true)]
        [InlineData(5 , false )]
        public void FindIfExistingValue(int x , bool expected)
        {
            // Arrange
            List linkedList3 = new List();
            linkedList3.Insert(3);
            linkedList3.Insert(2);
            linkedList3.Insert(1);

            // Act
            bool result = linkedList3.includes(x);

            // Assert
            Assert.Equal(result , expected);
        }

        [Fact]
        public void ReturnsCollectionOfAllValues()
        {
         List list = new List();
        list.Insert(3);
            list.Insert(2);
            list.Insert(1);

            // Act
            string result = list.ToString();

            // Assert
            Assert.Equal("{ 1 } -> { 2 } -> { 3 } -> NULL", result);
        }
    }

}


