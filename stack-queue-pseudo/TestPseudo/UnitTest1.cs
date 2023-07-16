using stack_queue_pseudo;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Enqueue_and_DequeuesMoreThanOneValue()
        {
            // Arrange
            PseudoQueue queue = new PseudoQueue();

            // Act
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            // Assert
            Assert.Equal(3, queue.Dequeue());
            Assert.Equal(4, queue.Dequeue());
            Assert.Equal(5, queue.Dequeue());
        }
        [Fact]
        public void DequeueEmptyQueue()
        {
            // Arrange
            PseudoQueue queue = new PseudoQueue();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }
        [Fact]
        public void EnqueueAndDequeueUntailItsEmpty()
        {
            // Arrange
            PseudoQueue queue = new PseudoQueue();

            // Act
            queue.Enqueue(10);
            queue.Enqueue(20);
           
            queue.Enqueue(30);
             queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            // Assert

            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }
    }
}