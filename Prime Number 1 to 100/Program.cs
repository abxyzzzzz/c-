using System;

namespace Prime_Number_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = 99;
            for (int i = 1; i <= g; i++)
            {

                if (i % 2 == 1)
                {
                    Console.WriteLine("its a prime number :",i );
                }

                else
                {
                    Console.WriteLine("not prime" + i);
                }
            }

        }
    }
}
