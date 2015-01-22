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
    }

    public class FakeInteractor : IUserInteractor
    {
        public string Output = "";
        public void DisplayMessage(string msg)
        {
            Output += msg;
        }
    }
}
