using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniTest
{
    internal class SimpleLinkedListTest
    {
        [Test]
        public void Sum_FixNumber_ReturnsCorrectSum()
        {
            MySum ms = new MySum();
            var ret = ms.SumUpValues_Iterative(3);
            Assert.AreEqual(ret, 6);
        }
        private class MySum
        {
            public int SumUpValues_Iterative(int number)
            {
                var ret = 0;
                for (int i = 1; i <= number; i++)
                    ret += i;
                return ret;
            }
        }
    }
}

