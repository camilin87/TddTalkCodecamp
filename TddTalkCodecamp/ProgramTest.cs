using System;
using FibProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddTalkCodecamp
{
    [TestClass]
    public class ProgramTest
    {
        private FakeInteractor _interactor;

        [TestInitialize]
        public void Initialize()
        {
            _interactor = new FakeInteractor();
            Program.Interactor = _interactor;
        }

        [TestMethod]
        public void PromptsTheUserForANumber()
        {
            Program.Main(null);

            Assert.IsTrue(_interactor.Output.Contains("Enter a number"));
        }

        [TestMethod]
        public void CalculatesTheFibonacciNumber()
        {
            _interactor.Input = "6";

            Program.Main(null);

            Assert.IsTrue(_interactor.Output.Contains("The number is 8"));
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
