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

            var result = new FibCalc().Get(ReadFibNumberEnteredByUser());
            _programIo.WriteLine(string.Format("Fibonacci number is {0}", result));
        }

        private int ReadFibNumberEnteredByUser()
        {
            var readLine = _programIo.ReadLine();

            if (string.IsNullOrEmpty(readLine))
            {
                return 0;
            }

            return int.Parse(readLine);
        }
    }
}