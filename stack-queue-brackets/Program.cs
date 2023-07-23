namespace stack_queue_brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( StackQueueBrackets.ValidateBrackets(""));
            Console.WriteLine(StackQueueBrackets.ValidateBrackets("}{"));
            Console.WriteLine(StackQueueBrackets.ValidateBrackets("(){}()[]"));

        }
    }
}