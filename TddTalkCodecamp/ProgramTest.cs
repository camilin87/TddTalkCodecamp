using System;
using FibProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddTalkCodecamp
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void PromptsTheUserForANumber()
        {
            var interactor = new FakeInteractor();
            Program.Interactor = interactor;

            Program.Main(null);

            Assert.IsTrue(interactor.Output.Contains("Enter a number"));
        }

        [TestMethod]
        public void CalculatesTheFibonacciNumber()
        {
            var interactor = new FakeInteractor();
            interactor.Input = "6";
            Program.Interactor = interactor;

            Program.Main(null);

            Assert.IsTrue(interactor.Output.Contains("The number is 8"));
        }
    }

    public class FakeInteractor : IUserInteractor
    {
        public string Output = string.Empty;
        public string Input = string.Empty;

        public void DisplayMessage(string msg)
        {
            Output += msg;
        }

        public string Read()
        {
            return Input;
        }
    }
}
