using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Code30Days
{
    public class LinkedListDuplicate
    {
        public sealed class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
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


        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);
            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;
            }
            return head;
        }


        public static Node removeDuplicates(Node head)
        {
            //Write your code here
            Node start = head;
            Node nodeNextNew = null;
            while (start.next != null)
            {
                if (start.data == start.next.data)
                {
                    nodeNextNew = start.next.next;
                    start.next = null;
                    start.next = nodeNextNew;
                }
                else
                    start = start.next;
            }

            return head;
        }
    }
}
