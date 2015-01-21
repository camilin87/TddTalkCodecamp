namespace FibProgram
{
    public class FibCalc
    {
        public int Get(int n)
        {
            if (n < 2)
                return n;

            return Get(n - 1) + Get(n - 2);
        }
    }
}