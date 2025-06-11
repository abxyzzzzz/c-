using System;
using System.Linq;

namespace String_to_UPPER_or_LOWER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello Please enter \"U\" for UpperCase or \"L\" for LowerCase");
            string read = Console.ReadLine();

            if (read == "u" || read == "U")
            {
                Console.WriteLine("Please enter the text to convert to upper");
                string u = Console.ReadLine();
                Console.WriteLine(u.ToUpper());
            }
            else if (read == "l" || read == "L")
            {
                Console.WriteLine("Please enter the text to convert to lower");
                string l = Console.ReadLine();
                Console.WriteLine(l.ToLower());

            }
            else
            {
                Console.WriteLine("ERORRR");
            }
        }
    }
}
