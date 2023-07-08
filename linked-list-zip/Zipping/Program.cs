using System.Collections.Generic;

namespace Zipping
{
    public class Program
    {
        static void Main(string[] args)
        {
            ZipList list1 = new ZipList();
            list1.Head = new Node(0);
            list1.Head.Next = new Node(2);
            list1.Head.Next.Next = new Node(4);
            list1.Head.Next.Next.Next = new Node(6);
            ZipList list2 = new ZipList();
            list2.Head = new Node(1);
            list2.Head.Next = new Node(3);
            list2.Head.Next.Next = new Node(5);

            ZipList List3 = ZipList.ZipLists(list1, list2);


        }
    }
}