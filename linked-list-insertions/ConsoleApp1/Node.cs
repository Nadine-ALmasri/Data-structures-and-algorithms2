using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
 public  class Node
    {
       public int data;
       public  Node next;
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
            public Node ( int value)
    {
        this.data = value;
      next = null;
    }
}             }
    
   
