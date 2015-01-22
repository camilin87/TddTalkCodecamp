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
        }

    }
}
