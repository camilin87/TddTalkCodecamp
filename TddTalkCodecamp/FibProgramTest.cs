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
    }
}
