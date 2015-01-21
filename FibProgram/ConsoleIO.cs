using System;

namespace FibProgram
{
    public class ConsoleIO : IProgramIO
    {
        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}