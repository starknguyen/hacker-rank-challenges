using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.DataStructures.CSharp
{
    public class SimpleLinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }

        }


        public static Node insert(Node head, int data)
        {
            //Complete this method
            if (head == null)
                return new Node(data) { next = null };

            Node n = new Node(data);
            if (head.next == null)
                head.next = n;
            else
            {
                var temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = n;
            }

            return head;
        }


        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

    }
}
