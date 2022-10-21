using Generic;
using NUnit.Framework;

namespace SingleLinkedListTests
{
    public class SingleLinkedListTests
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
    }
}