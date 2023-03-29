using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LinkedList
{
    public class Node
    {
        public string Data;
        public Node Next;

        public Node(string data, Node next)
        {
            Data = data;
            Next = next;
        }
    }
}
