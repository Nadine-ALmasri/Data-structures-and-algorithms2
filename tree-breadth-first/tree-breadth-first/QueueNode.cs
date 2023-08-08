using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_breadth_first
{
    internal class QueueNode
    {
    public Node Node;
        public QueueNode Next;

        public QueueNode(Node node)
        {
            Node = node;
            Next = null;
        }
    }

    public class Queue
    {
        private QueueNode Front;
        private QueueNode Rear;

       public Queue()
        {
            Front = null;
            Rear = null;
        }

        public bool IsEmpty()
        {
            return Front == null;
        }

        public void Enqueue(Node node)
        {
            QueueNode newNode = new QueueNode(node);

            if (Rear == null)
            {
                Front = newNode;
                Rear = newNode;
            }
            else
            {
                Rear.Next = newNode;
                Rear = newNode;
            }
        }

        public Node Dequeue()
        {
            if (Front == null)
                return null;

            Node node = Front.Node;
            Front = Front.Next;

            if (Front == null)
                Rear = null;

            return node;
        }
    }

}
