using System;

namespace FibProgram
{
    class ConsoleInteractor : IUserInteractor
    {
        public void DisplayMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}