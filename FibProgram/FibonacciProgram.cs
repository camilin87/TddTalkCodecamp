namespace FibProgram
{
    public class FibonacciProgram
    {
        private readonly IUserInteractor _interactor;

        public FibonacciProgram(IUserInteractor interactor)
        {
            _interactor = interactor;
        }

        public void Run()
        {
            _interactor.DisplayMessage("Enter a number");
            var fibIdx = ReadFibonacciIndex();

            var result = new FibCalc().Get(fibIdx);
            _interactor.DisplayMessage(string.Format("The number is {0}", result));
        }

        private int ReadFibonacciIndex()
        {
            var numberStr = _interactor.Read();

            if (string.IsNullOrEmpty(numberStr))
            {
                return 0;
            }

            return int.Parse(numberStr);
        }

    }
}