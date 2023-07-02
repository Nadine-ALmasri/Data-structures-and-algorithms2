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
        public void AddNodeToEnd()
        {
            // Arrange
        List linkedList6 = new List();

            // Act
            linkedList6.append(10);

            // Assert
            Assert.Equal("{ 10 } -> NULL", linkedList6.ToString());
        }

        [Fact]
        public void CanAddMultipleNodesToEnd()
        {
            // Arrange
         List linkedList = new List();

            // Act
            linkedList.append(10);
            linkedList.append(20);
            linkedList.append(30);

            // Assert
            Assert.Equal("{ 10 } -> { 20 } -> { 30 } -> NULL", linkedList.ToString());
        }

        [Fact]
        public void CanInsertNodeBeforeMiddleNode()
        {
            // Arrange
        List list1 = new List();
          list1.append(10);
            list1.append(30);

            // Act
            list1.Insertbefore(20, 30);

            // Assert
            Assert.Equal("{ 10 } -> { 20 } -> { 30 } -> NULL", list1.ToString());
        }

        [Fact]
        public void InsertNodeBeforeFirstNode()
        {
          List list = new List();
           list.append(2);
             list.append(3);

            // Act
            list.Insertbefore(1, 2);

            // Assert
            Assert.Equal("{ 1 } -> { 2 } -> { 3 } -> NULL", list.ToString());
        }

        [Fact]
        public void InsertNodeAfterMiddleNode()
        {
            // Arrange
         List linkedList8 = new List();
            linkedList8.append(5);
            linkedList8.append(7);

            // Act
            linkedList8.InsertAfter(6, 5);

            // Assert
            Assert.Equal("{ 5 } -> { 6 } -> { 7 } -> NULL", linkedList8.ToString());
        }

        [Fact]
        public void InsertNodeAfterLastNode()
        {// Arrange
            List linkedList = new  List();
            linkedList.append(10);
            linkedList.append(20);

            

            // Assert
            Assert.Equal("{ 10 } -> { 20 } -> NULL", linkedList.ToString());
        }
    }

}
