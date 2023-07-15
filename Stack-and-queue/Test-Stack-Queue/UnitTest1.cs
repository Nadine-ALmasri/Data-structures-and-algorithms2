using stack_queue;

namespace Test_Stack_Queue
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void Testpush_onto_stack()
        {
            Stack stack2 = new Stack();
            stack2.Push(1);
            Assert.False(stack2.IsEmpty());
            Assert.Equal(1, stack2.Peek());

        }
        [Fact]
        public void Testpush_multible_onto_stack()
        {
            Stack stack3 = new Stack();
            stack3.Push(1);
            stack3.Push(2);
            stack3.Push(3);
            Assert.False(stack3.IsEmpty());
            Assert.Equal(3, stack3.Peek());

        }
        [Fact]
        public void Testpop_onto_stack()
        {
            Stack stack4 = new Stack();
            stack4.Push(1);
            stack4.Push(2);
            Assert.False(stack4.IsEmpty());
            Assert.Equal(2, stack4.Pop());

        }
        [Fact]
        public void Test_empty_stack_after_multiple_pops()
        {
            Stack stack5 = new Stack();
            stack5.Push(1);
            stack5.Push(2);
            stack5.Pop();
            stack5.Pop();
            Assert.True(stack5.IsEmpty());


        }
        [Fact]
        public void TestForPeek()
        {
            Stack stack6 = new Stack();
            stack6.Push(1);
            stack6.Push(2);
            Assert.Equal(2, stack6.Peek());
        }
        [Fact]
        public void TestFor_instantiate_empty_stack() {
            Stack NewStack = new Stack();
            Assert.True(NewStack.IsEmpty());
        }
        [Fact]
        public void Calling_pop_peek_on_empty_stack()
        {
            Stack stack7 = new Stack();
           Assert.Throws<InvalidOperationException>(() => stack7.Pop());
        }
        [Fact]
        public void enqueue_into_queue()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
          
            Assert.False(queue.IsEmpty());
            Assert.Equal(1, queue.Peek());
        }
        [Fact]
        public void enqueue_multi_values()
        {
            Queue queue2 = new Queue();
            queue2.Enqueue(1);
            queue2.Enqueue(2);
            queue2.Enqueue(3);
            Assert.False(queue2.IsEmpty());
            Assert.Equal(1, queue2.Peek());
        }
        [Fact]
        public void Dequeu_from_queue ()
        {
            Queue queue3 = new Queue();
            queue3.Enqueue(1);
            queue3.Enqueue(2);
            queue3.Enqueue(3);
            queue3.Enqueue(4);
            Assert.False(queue3.IsEmpty());
            Assert.Equal(1, queue3.Dequeue());
        }
        [Fact]
        public void Peek_from_queue()
        {
            Queue queue4 = new Queue();
            queue4.Enqueue(1);
            queue4.Enqueue(2);
            queue4.Enqueue(3);
            queue4.Enqueue(4);
            Assert.False(queue4.IsEmpty());
            Assert.Equal(1, queue4.Peek());
        }
        [Fact]
        public void Empty_The_queue_After_Multiple_Dequeue()
        {
            Queue queue5 = new Queue();
            queue5.Enqueue(1);
            queue5.Enqueue(2);
            queue5.Enqueue(3);
            queue5.Enqueue(4);
            queue5.Dequeue();
            queue5.Dequeue();
            queue5.Dequeue();
            queue5.Dequeue();
            Assert.True(queue5.IsEmpty());
          
        }
        [Fact]
        public void instantiate_an_empty_queue()
        {
            Queue queue6 = new Queue();
            Assert.True(queue6.IsEmpty());
        }
        [Fact]
        public void Calling_Enqueue_Dequeue_on_empty_queue()
        {
            Queue queue8 = new Queue();
            Assert.Throws<InvalidOperationException>(() => queue8.Dequeue());
        }
    }


}