namespace stack_queue_pseudo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue(12);
            queue.Enqueue(15);
            queue.Enqueue(18);
            Console.WriteLine(queue.Dequeue());  
            Console.WriteLine(queue.Dequeue());
        }
    }
}