namespace FibProgram
{
    public class FibProgram
    {
        private readonly IProgramIO _programIo;

        public FibProgram(IProgramIO programIo)
        {
            _programIo = programIo;
        }

        public void Run()
        {
            _programIo.WriteLine("What fibonacci number do you want?");
        }
    }
}