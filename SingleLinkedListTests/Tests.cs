using Generic;
using NUnit.Framework;


namespace SingleLinkedListTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetNode_MultipleNodes_ReturnsNode()
        {
            var myLL = new SimpleLinkedList();
            myLL.insertLast(1);
            myLL.insertLast(2);
            var node = myLL.getNode(1);
            Assert.AreEqual(1, node.data);
            // da sollte ein Node zurückkommen...
        }

        [Test]
        public void InsertLast_MultipleNodes_ElementsAreAddedAtTheEnd()
        {
            var myLL = new SimpleLinkedList();
            myLL.insertLast(1);
            myLL.insertLast(2);
            var node = myLL.GetHead();
            Assert.AreEqual(node.data, 1);
            Assert.AreEqual(node.next.data, 2);
        }

        [Test]
        public void InsertFirst_MultipleNodes_ElementsAreAddedInFront()
        {
            var myLL = new SimpleLinkedList();
            myLL.insertFirst(1);
            myLL.insertFirst(2);
            var node = myLL.GetHead();
            Assert.AreEqual(node.data, 2);
            Assert.AreEqual(node.next.data, 1);
        }

        [Test]
        public void after_MultipleElements_ElementsAreAddedAtTheEnd()
        {
            var myLL = new SimpleLinkedList();
            myLL.insertLast(1);
            myLL.insertLast(2);
            myLL.insertLast(5);
            var node = myLL.getNode(2);
            myLL.after(node, 3);
            node = myLL.getNode(0);
            Assert.AreEqual(1, node.data);
            Assert.AreEqual(2, node.next.data);
            Assert.AreEqual(3, node.next.next.data);
        }

        [Test]
        public void deleteNode_ElementInTheMiddle_ElementIsDeleted()
        {
            var myLL = new SimpleLinkedList();
            myLL.insertLast(1);
            myLL.insertLast(2);
            myLL.insertLast(3);
            myLL.insertLast(5);
            var node = myLL.getNode(3);
            myLL.deleteNode();
            node = myLL.getNode(0);
            Assert.AreEqual(1, node.data);
            Assert.AreEqual(2, node.next.data);
            Assert.AreEqual(5, node.next.next.data);
        }

        [Test]
        public void SwitchNodes_TwoNodes_NodesAreSwitched()
        {
            var myLL = new SimpleLinkedList();
            myLL.insertLast(1);
            myLL.insertLast(2);
            var node = myLL.getNode(1);
            var node1 = myLL.getNode(2);

            myLL.SwitchNodes(node, node1);

            Assert.AreEqual(2, node.data);
        }

        [Test]
        public void InsertionSortInverse_listSorted_BiggestToLowest()
        {
            var myLL = new SimpleLinkedList();
            myLL.insertFirst(10);
            myLL.insertFirst(1);
            myLL.insertFirst(5);
            myLL.insertionSortInverse(myLL.head);
            Assert.AreEqual(myLL.head.data, 10);
            Assert.AreEqual(myLL.head.next.data, 5);
            Assert.AreEqual(myLL.head.next.next.data, 1);
        }

        [Test]
        public void BubbleSort()
        {
            var myLL = new SimpleLinkedList();
            myLL.insertFirst(10);
            myLL.insertFirst(1);
            myLL.insertFirst(5);
            myLL.BubbleSort();
            Assert.AreEqual(myLL.head.data, 1);
            Assert.AreEqual(myLL.head.next.data, 5);
            Assert.AreEqual(myLL.head.next.next.data, 10);
        }

        [Test]
        public void Insert_AddsNodeToTree()
        {
            BinaryTree tree = new BinaryTree();
            tree.Inserttree(5);

            Assert.AreEqual(5, tree.root.data);
            Assert.IsNull(tree.root.left);
            Assert.IsNull(tree.root.right);
        }

        [Test]
        public void Insert_AddsNodesInCorrectOrder()
        {
            BinaryTree tree = new BinaryTree();
            tree.Inserttree(5);
            tree.Inserttree(3);
            tree.Inserttree(7);
            tree.Inserttree(2);
            tree.Inserttree(4);
            tree.Inserttree(6);
            tree.Inserttree(8);

            Assert.AreEqual(5, tree.root.data);
            Assert.AreEqual(3, tree.root.left.data);
            Assert.AreEqual(2, tree.root.left.left.data);
            Assert.AreEqual(4, tree.root.left.right.data);
            Assert.AreEqual(7, tree.root.right.data);
            Assert.AreEqual(6, tree.root.right.left.data);
            Assert.AreEqual(8, tree.root.right.right.data);
        }

        [Test]
        public void TestQuickSort()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int[] expected = { 1, 5, 7, 8, 9, 10 };

            Program.QuickSort(arr, 0, arr.Length - 1);

            Assert.AreEqual(expected, arr);
        }
    }
}