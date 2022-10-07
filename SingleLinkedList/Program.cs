using Generic;

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

            list1.printList();
            list1.insert(4);
            list1.count();
        }
    }
} 