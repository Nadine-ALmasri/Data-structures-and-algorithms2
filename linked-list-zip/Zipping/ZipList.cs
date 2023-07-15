using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zipping;

namespace Zipping
{
    public class ZipList

    {
        public Node Head { get; set; }

        public ZipList()
        {
            Head = null;
        }

        public static ZipList ZipLists(ZipList list1, ZipList list2)
        {
            if (list1.Head == null)
                return list2;
            if (list2.Head == null)
                return list1;

            Node current1 = list1.Head;
            Node current2 = list2.Head;
            ZipList List3 = new ZipList();
            Node currentList3 = null;

            while (current1 != null && current2 != null)
            {
              

                if (List3.Head == null)
                {
                   List3.Head = current1;
                    currentList3 = List3.Head;
                }
                else
                {
                    currentList3.Next = current1;
                    currentList3 = currentList3.Next;
                }

                current1 = current1.Next;

                currentList3.Next = current2;
                currentList3 = currentList3.Next;

                current2 = current2.Next;
            }

            if (current1 != null)
                currentList3.Next = current1;
            else if (current2 != null)
                currentList3.Next = current2;

            Node current = List3.Head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
            return List3;
        }
    }

}
