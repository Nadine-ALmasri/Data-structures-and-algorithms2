using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zipping;

namespace stack_queue
{
    public class Queue
    {
        private Node front;
        private Node back;

        public Queue()
        {
            front = null;
            back = null;
        }
        public bool IsEmpty()
        {
            return front == null;
        }
        public void Enqueue(int value)
        {
            Node newNode = new Node(value);

            if (IsEmpty())
            {
                front = newNode;
                back = newNode;
            }
            else
            {
                back.Next = newNode;
                back = newNode;
            }
        }
        public object Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            object value = front.Data;
            front = front.Next;

            if (front == null)
            {
               back = null;
            }

            return value;
        }

        public object Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return front.Data;
        }
    }
}
