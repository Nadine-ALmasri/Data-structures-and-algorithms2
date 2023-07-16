namespace stack_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stack stack = new Stack();

            Console.WriteLine(stack.IsEmpty());
            stack.Push(5);
            stack.Push(8);
            stack.Push(10);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


            Queue queue = new Queue();
            Console.WriteLine(queue.IsEmpty());
            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Enqueue(2);
            Console.WriteLine(queue.Dequeue()); 
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.IsEmpty());
        }
    }
}