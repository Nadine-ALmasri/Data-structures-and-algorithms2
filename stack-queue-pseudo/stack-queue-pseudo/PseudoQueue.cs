using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue_pseudo
{
    public class PseudoQueue

    {
        private Stack stack1;
        private Stack stack2;

        public PseudoQueue()
        {
            stack1 = new Stack();
            stack2 = new Stack();
        }

        public void Enqueue(object value)
        {
            // Move all elements from stack1 to stack2
            while (!stack1.IsEmpty())
            {
                stack2.Push(stack1.Pop());
            }

            // Push the new value onto stack1
            stack1.Push(value);

            // Move all elements back from stack2 to stack1
            while (!stack2.IsEmpty())
            {
                stack1.Push(stack2.Pop());
            }
        }

        public object Dequeue()
        {
            if (stack1.IsEmpty())
            {
                throw new InvalidOperationException("PseudoQueue is empty");
            }

            return stack1.Pop();
        }
    }
}

