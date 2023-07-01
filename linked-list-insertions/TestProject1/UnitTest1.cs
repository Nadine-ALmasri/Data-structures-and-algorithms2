using LinkedList;
namespace TestProject1
{
    public class UnitTest1
    {
       
        public void Test1()
        {

        }
        [Fact]
        public void CanAddNodeToEnd()
        {
            // Arrange
     List linkedList = new List();

            // Act
      List.append(10);

            // Assert
            Assert.Equal("{ 10 } -> NULL", linkedList.ToString());
        }

        [Fact]
        public void CanAddMultipleNodesToEnd()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();

            // Act
            linkedList.Append(10);
            linkedList.Append(20);
            linkedList.Append(30);

            // Assert
            Assert.Equal("{ 10 } -> { 20 } -> { 30 } -> NULL", linkedList.ToString());
        }

        [Fact]
        public void CanInsertNodeBeforeMiddleNode()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(10);
            linkedList.Append(30);

            // Act
            linkedList.InsertBefore(30, 20);

            // Assert
            Assert.Equal("{ 10 } -> { 20 } -> { 30 } -> NULL", linkedList.ToString());
        }

        [Fact]
        public void CanInsertNodeBeforeFirstNode()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(20);
            linkedList.Append(30);

            // Act
            linkedList.InsertBefore(20, 10);

            // Assert
            Assert.Equal("{ 10 } -> { 20 } -> { 30 } -> NULL", linkedList.ToString());
        }

        [Fact]
        public void CanInsertNodeAfterMiddleNode()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(10);
            linkedList.Append(30);

            // Act
            linkedList.InsertAfter(10, 20);

            // Assert
            Assert.Equal("{ 10 } -> { 20 } -> { 30 } -> NULL", linkedList.ToString());
        }

        [Fact]
        public void CanInsertNodeAfterLastNode()
        {
            // Arrange
            LinkedList linkedList = new LinkedList();
            linkedList.Append(10);
            linkedList.Append(20);

            // Act
            linkedList.InsertAfter(20, 30);

            // Assert
            Assert.Equal("{ 10 } -> { 20 } -> { 30 } -> NULL", linkedList.ToString());
        }
    }
}
}