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

            var node = list1.getNode(1);
            var node1 = list1.getNode(2);


            list1.insertFirst(10);
            list1.BubbleSort();
            list1.printList();

        }
    }
} 