using System;

namespace Factorial_Number
{
    class Program
    {

          static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial Number is not correct");
            }

            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial += i;
            }

            return factorial;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(4));
        }
    }
}
