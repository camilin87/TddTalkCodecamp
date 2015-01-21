using System;
using FibProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddTalkCodecamp
{
    [TestClass]
    public class FibCalcTest
    {
        [TestMethod]
        public void TestFibonacci()
        {
            var values = new[] {0, 1, 1};
            for (int i = 0; i < values.Length; i++)
            {
                Assert.AreEqual(values[i], new FibCalc().Get(i));
            }
        }
    }
}
