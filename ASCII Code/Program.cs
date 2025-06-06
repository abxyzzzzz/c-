using System;

namespace ASCII_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Im ASCII code to DEC and DEC to ASCII");
            Console.WriteLine("Press 2 ASCII to DEC");
            Console.WriteLine("Press 1 DEC to ASCII");
            string read = Console.ReadLine();
            int red = Convert.ToInt32(read);

            if (red == 1)
            {
                Console.WriteLine("Enter your DEC number");
                string st = Console.ReadLine();
                int ints = Convert.ToInt32(st);
                char character = (char)ints;
                Console.WriteLine(character);
            }
            else if (red == 2)
            {
                string sgh = Console.ReadLine();
                int as2=Convert.ToInt32(sgh);
                int numbs = (int)as2;
                Console.WriteLine(numbs);

            }
            else
            {
                Console.WriteLine("EORRRRR");
            }


        }
    }
}
