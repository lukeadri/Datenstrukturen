using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class SimpleLinkedList
    {
        public Node head;

        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }

        public void insert(int newElement)
        {
            Node newNode = new Node(0);

            newNode.data = newElement;

            newNode.next = null;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = new Node(0);
                temp = head;
                while (temp.next != null)
                    temp = temp.next;

                temp.next = newNode;
            }
        }

        public int count()
        {
            Node temp = new Node(0);
            temp = this.head;

            int i = 0;

            while (temp != null)
            {
                i++;
                temp = temp.next;
            }

            Console.WriteLine(i);
            return i;
        }
    }
}
