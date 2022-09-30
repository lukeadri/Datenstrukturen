using System.Collections.Generic;
using NUnit.Framework;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Stack<string> stack = new Stack<string>();
            string item1 = "test", item2 = "test2";
            stack.Push(item1);
            stack.Push(item2);
            Assert.AreEqual(stack.Pop(), item2);
            Assert.AreEqual(stack.Pop(), item1);

        }
    }
}