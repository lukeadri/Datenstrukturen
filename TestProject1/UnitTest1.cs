using System.Collections.Generic;
using NUnit.;

namespace TestProject1
{
    public class UnitTest1
	{
		public void Test()
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