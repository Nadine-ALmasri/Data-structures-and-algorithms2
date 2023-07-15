using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zipping;

namespace stack_queue
{
    public class Stack
    {

        private Node top;

        public Stack()
        {
            top = null;
        }

        public void Push(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = top;
            top = newNode;
        }
        public bool IsEmpty()
        {
            return top == null;
        }
        public object Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            object value = top.Data;
            top = top.Next;
            return value;
        }
        public object Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return top.Data;
        }
    }
}
