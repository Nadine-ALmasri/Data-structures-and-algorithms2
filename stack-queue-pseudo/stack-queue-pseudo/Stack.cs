using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue_pseudo
{
    public class Stack
    {
        private ArrayList items;

        public Stack()
        {
            items = new ArrayList();
        }

        public void Push(object item)
        {
            items.Add(item);
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            object item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public object Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return items[items.Count - 1];
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }
}
