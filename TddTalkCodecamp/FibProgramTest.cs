using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddTalkCodecamp
{
    [TestClass]
    public class FibProgramTest
    {
        [TestMethod]
        public void PrompsTheUser()
        {
            var programIo = new StringIO();

            new FibProgram.FibProgram(programIo).Run();

            var userWasPrompted = programIo.Output.Contains("What fibonacci number do you want?");
            Assert.IsTrue(userWasPrompted);
        }

        [TestMethod]
        public void DisplaysTheFibonacciNumber()
        {
            var programIo = new StringIO();
            programIo.Input = "3";

            new FibProgram.FibProgram(programIo).Run();

            var numberWasPresented = programIo.Output.Contains("Fibonacci number is 2");
            Assert.IsTrue(numberWasPresented);
        }
    }
}
