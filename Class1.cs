using System;

public class Class1
{
	public Class1()
	{
		public void Test()
        {
			stack<string> stack = new stack<string>();
			string item1 = "test", item2 = "test2";
			stack.Push(item1);
			stack.Push(item2);
			Assert.AreEqual(stack.Pop(), item2);
			Assert.AreEqual(stack.Pop(), item1);
		}
	}
}
