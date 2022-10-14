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

        public void insertLast(int newElement)
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

        public int countNode()
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

        public void insertFirst(int newElement)
        {
            Node newNode = new Node(0);
            newNode.data = newElement;
            newNode.next = head;
            head = newNode;
        }

        public void getNode(int argData)
        {
            Node temp = new Node(0);
            temp = this.head;

            int found = 0;
            int i = 0;

            if (temp != null)
            {

                while (temp != null)
                {
                    i++;
                    if (temp.data == argData)
                    {
                        found++;
                        break;
                    }
                    temp = temp.next;
                }

                if (found == 1)
                {
                    Console.WriteLine(argData + " befindet sich an der Stelle " + i);
                }

                else
                {
                    Console.WriteLine(argData + " befindet sich nicht in der Liste");
                }
            }
        }

        public void deleteNode()
        {
            if (this.head != null)
            {
                Node temp = this.head;
                this.head = this.head.next;
                temp = null;
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        public Node GetHead()
        {
            return this.head;
        }

        public void after(int newElement, int nodePosition)
        {
            Node newNode = new Node(0);
            newNode.data = newElement;
            newNode.next = null;

            if (nodePosition < 1)
            {
                Console.Write("Die gewünschte Position des Nodes muss größer als 0 sein");
            }

            else if (nodePosition == 1)
            {
                newNode.next = head;
                head = newNode;
            }

            else
            {
                Node temp = new Node(0);
                temp = head;
                for (int i = 1; i < nodePosition - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }

                if (temp != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
            }
        }
    }
}
