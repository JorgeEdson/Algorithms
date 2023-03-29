using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.LinkedList
{
    static class LinkedListOperations
    {
        private static Node head;
        private static Node tail;
        public static Node StartLinkedList() 
        {
            head = new Node("A", null);
            
            var nodeB = new Node("B", null);
            head.Next = nodeB;

            var nodeC = new Node("C", null);
            nodeB.Next = nodeC;

            tail = new Node("D", null);
            nodeC.Next = tail;

            return head;
        }

        public static void ShowLinkedList(Node paramNode) 
        {
            var auxNode = paramNode;
            while (auxNode != null) 
            {
                Console.Write(auxNode.Data + " -> ");
                auxNode = auxNode.Next;
            }
            Console.WriteLine("End LikedList");
        }

        public static void AddNode(Node paramNode) 
        {
            tail.Next = paramNode;
            tail = paramNode;
        }
        public static void InsertNodeInPosition(Node paramNode, int paramPosition) 
        {
            var auxNode = head;
            int i = 0;
            while (auxNode.Next != null && i < paramPosition - 1) 
            {
                auxNode = auxNode.Next;
                i++;
            }
            paramNode.Next = auxNode.Next;
            auxNode.Next = paramNode;
        }
        public static void RemoveNodeInPosition(int paramPosition) 
        {
            var auxNode = head;
            int i = 0;
            while (auxNode.Next != null && i < paramPosition - 1) 
            { 
                auxNode = auxNode.Next;
                i++;
            }
            var tempNode = auxNode.Next;
            auxNode.Next = auxNode.Next.Next;
            tempNode.Next = null;
        }
    }
}
