using FibProgram;

namespace TddTalkCodecamp
{
    public class StringIO : IProgramIO
    {
        public string Output = string.Empty;

        public void WriteLine(string str)
        {
            Output += str + "\r\n";
        }
    }
}