using System;

namespace Perfedt_Sqaure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello Im sqaure calculator Enter your number and i will say weather a perfect sqaure or not: ");
            string r = Console.ReadLine();
            int read = Convert.ToInt32(r);

            int sqaure = (int)Math.Sqrt(read);

            if (sqaure*sqaure ==read)
            {
                Console.WriteLine("perfect: " + sqaure);
            }
            else
            {
                Console.WriteLine("not perfect: ");
            }
        }

    }
}
