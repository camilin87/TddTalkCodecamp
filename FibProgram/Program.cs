using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibProgram
{
    public class Program
    {
        public static IUserInteractor Interactor = new ConsoleInteractor();

        public static void Main(string[] args)
        {
            Interactor.DisplayMessage("Enter a number");
            var fibIdx = ReadFibonacciIndex();

            var result = new FibCalc().Get(fibIdx);
            Interactor.DisplayMessage(string.Format("The number is {0}", result));
        }

        private static int ReadFibonacciIndex()
        {
            var numberStr = Interactor.Read();

            if (string.IsNullOrEmpty(numberStr))
            {
                return 0;
            }

            return int.Parse(numberStr);
        }
    }
}
