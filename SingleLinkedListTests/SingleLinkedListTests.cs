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
            //var node = myLL.getNode(1);
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
    }
}