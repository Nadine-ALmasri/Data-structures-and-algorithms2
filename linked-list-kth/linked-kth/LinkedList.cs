using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace LinkedList
{
    public class LinkedList
    {
        public Node Head;
        public Node Tail;
        public LinkedList()
        {
            Head = Tail = null;
        }


        public void append(int value)
        {
            Node item = new Node(value);
            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                Tail.Next = item;
                Tail = item;
            }
        }

        public void Display()
        {
            Node Start = Head;
            if (Start == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                while (Start != null)
                {
                    Console.WriteLine(Start.Data);
                    Start = Start.Next;
                }
            }
        }
        public void AddFirstList(int value)
        {
            Node item = new Node(value);
            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                item.Next = Head;
                Head = item;
            }
        }
        public bool includes(int value)
        {
            Node current = Head;
            int pos = 1;
            while (current != null)
            {
                if (current.Data == value)
                {
                    Console.WriteLine($"THE VALUE {current.Data} WAS FOUND AT Position {pos}");
                    return true;
                }
                else
                {
                    current = current.Next;
                    pos++;
                }
                if (current == null)
                {
                    Console.WriteLine(" THE VALUE WAS NOT FOUND ");
                }

            }
            return false;
        }

        public string ToString()
        {
            Node current = Head;
            string result = ""; ;
            while (current != null)
            {

                result += "{ " + current.Data + " } -> ";
                current = current.Next;
            }
            result += "NULL";
            return result;
        }
        public void InsertAfter(int Newvalue, int value)
        {


            Node current = Head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    Console.WriteLine($"INSERTING {Newvalue} AFTER {value}");
                    Node New = new Node(Newvalue);
                    New.Next = current.Next;
                    current.Next = New;
                    return;

                    {
                        current = current.Next;

                    }
                    throw new ArgumentException($"Value {value} not found in the linked list.");
                }

            }
        }
        public void Insertbefore(int Newvalue, int value)
        {
            if (Head == null)
            {
                throw new InvalidOperationException("The linked list is empty.");
            }
            if (Head.Data == value)
            {

                Node newNode = new Node(Newvalue);
                newNode.Next = Head;
                Head = newNode;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data == value)
                {
                    Console.WriteLine($"INSERTING {Newvalue} BEFORE {value}");
                    Node New = new Node(Newvalue);
                    New.Next = current.Next;
                    current.Next = New;
                    return;
                }

                {
                    current = current.Next;

                }

            }
            Console.WriteLine($"Value {value} not found in the linked list.");


        }
        public int KthFromEnd(int k)
        {
            int length = 0;
            Node current = Head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }

            if (k >= length || k < 0)
            {
                Console.WriteLine("THE VALUE WAS NOT FOUND");
                return -1; // Return a default value to indicate failure
            }

            Node currentValue = Head;
            for (int i = 0; i < length - k - 1; i++)
            {
                currentValue = currentValue.Next;
            }

            Console.WriteLine($"THE VALUE {currentValue.Data} WAS FOUND AT POSITION {k}");
            return currentValue.Data;
        }
    }
    }



