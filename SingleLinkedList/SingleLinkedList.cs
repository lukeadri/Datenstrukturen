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
        public Node sorted;

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

        public Node getNode(int argData)
        {
            Node temp = new Node(0);
            temp = this.head;

            if (temp != null)
            {

                while (temp != null)
                {
                    if (temp.data == argData)
                    {
                        return temp;
                    }
                    temp = temp.next;
                }
            }
            return null;
        }

        public Node deleteNode()
        {
            if (this.head != null)
            {
                Node temp = this.head;
                this.head = this.head.next;
                temp = null;
                return temp;
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            return null;
        }

        public Node GetHead()
        {
            return this.head;
        }

        public void after(Node insertafter, int new_data)
        {
            if (after == null)
            {
                Console.WriteLine("Dieser Node existiert nicht");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = insertafter.next;
            insertafter.next = new_node;
        }

        public Node SwitchNodes(Node firstNode, Node secondNode)
        {
            int val = firstNode.data;
            firstNode.data = secondNode.data;
            secondNode.data = val;
            return firstNode;
        }

        public void insertionSort(Node list)
        {
            sorted = null;
            Node current = list;

            while (current != null)
            {
                Node next = current.next;
                sortedInsert(current);
                current = next;
            }
            head = sorted;
        }

        void sortedInsert(Node newNode)
        {
            if (sorted == null || sorted.data <= newNode.data)
            {
                newNode.next = sorted;
                sorted = newNode;
            }
            else
            {
                Node current = sorted;

                while (current.next != null &&
                        current.next.data > newNode.data)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
            }
        }

        public void insertionSortInverse(Node list)
        {
            sorted = null;
            Node current = list;

            while (current != null)
            {
                Node next = current.next;
                sortedInsertInverse(current);
                current = next;
            }
            head = sorted;
        }

        void sortedInsertInverse(Node newNode)
        {
            if (sorted == null || sorted.data <= newNode.data)
            {
                newNode.next = sorted;
                sorted = newNode;
            }
            else
            {
                Node current = sorted;

                while (current.next != null &&
                        current.next.data > newNode.data)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
            }
        }

        public void BubbleSort()
        {
            var Node = head;

            while (Node != null)
            {
                for (var cur = head; cur.next != null; cur = cur.next)
                {
                    if (cur.next == null)
                    {
                        continue;
                    }
                    if (cur.data > cur.next.data)
                    {
                        (cur.data, cur.next.data) = (cur.next.data, cur.data);
                    }
                }
                Node = Node.next;
            }
            Console.WriteLine("BubbleSorted list ");
        }
    }
  
}
