using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddTalkCodecamp
{
    [TestClass]
    public class FibProgramTest
    {
        private StringIO _programIo;
        private FibProgram.FibProgram _fibProgram;

        [TestInitialize]
        public void Setup()
        {
            _programIo = new StringIO();
            _fibProgram = new FibProgram.FibProgram(_programIo);
        }

        [TestMethod]
        public void PrompsTheUser()
        {
            _fibProgram.Run();

            var userWasPrompted = _programIo.Output.Contains("What fibonacci number do you want?");
            Assert.IsTrue(userWasPrompted);
        }

        [TestMethod]
        public void DisplaysTheFibonacciNumber()
        {
            _programIo.Input = "3";

            _fibProgram.Run();

            var numberWasPresented = _programIo.Output.Contains("Fibonacci number is 2");
            Assert.IsTrue(numberWasPresented);
        }
    }
}
