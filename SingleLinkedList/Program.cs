﻿using Generic;

namespace GenerischeKlassen
{
    class Program
    {
        public static void Main(String[] args)
        {
            SimpleLinkedList list1 = new SimpleLinkedList();

            list1.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            list1.head.next = second;
            second.next = third;

            list1.after(87, 2);
            list1.getNode(1);
            list1.insertLast(4);
            list1.countNode();
            list1.insertFirst(0);
            list1.deleteNode();
            list1.printList();            
        }
    }
} 