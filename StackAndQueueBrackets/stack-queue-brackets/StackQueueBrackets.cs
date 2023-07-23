using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue_brackets
{
    public class StackQueueBrackets
    {
        public static bool ValidateBrackets(string input)
        {
            if (string.IsNullOrEmpty(input)) {
                Console.Write("The input is empty    ");
                return true;}

            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

            foreach (char character in input)
            {
                if (bracketPairs.ContainsKey(character))
                {
              
                    stack.Push(character);
                }
                else if (bracketPairs.ContainsValue(character))
                {
                    if (stack.Count == 0 || character != bracketPairs[stack.Pop()])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
