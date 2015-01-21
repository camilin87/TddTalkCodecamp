namespace FibProgram
{
    public class FibProgram
    {
        private readonly IProgramIO _programIo;
        private readonly FibCalc _fibCalc = new FibCalc();

        public FibProgram() : this(new ConsoleIO())
        {
            
        }

        public FibProgram(IProgramIO programIo)
        {
            _programIo = programIo;
        }

        public void Run()
        {
            var numberEnteredByUser = ReadFibNumberEnteredByUser();
            var result = _fibCalc.Get(numberEnteredByUser);
            DisplayResult(result);
        }

        private void DisplayResult(int result)
        {
            _programIo.WriteLine(string.Format("Fibonacci number is {0}", result));
        }

        private int ReadFibNumberEnteredByUser()
        {
            _programIo.WriteLine("What fibonacci number do you want?");
            var readLine = _programIo.ReadLine();

            if (string.IsNullOrEmpty(readLine))
            {
                return 0;
            }

            return int.Parse(readLine);
        }
    }
}