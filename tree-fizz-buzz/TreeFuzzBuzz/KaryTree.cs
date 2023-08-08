using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TreeFuzzBuzz;

namespace TreeFuzzBuzz
{
    public class KaryTree<T>
    {
        public TreeNode<T> Root { get; set; }

        public KaryTree(T root)
        {
            Root = new TreeNode<T>(root);
        }


    }
}

