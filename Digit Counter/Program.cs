using System;

namespace Digit_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I am Digit Counter Enter your Digit And I Will Check");
            string r = Console.ReadLine();
            int read = Convert.ToInt32(r).Length;

            Console.WriteLine(read);
            
            
        }
    }
}
