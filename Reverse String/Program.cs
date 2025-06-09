using System;
using System.Linq;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Plase enter your string and i will reverse it");
            string read = Console.ReadLine();

            Console.WriteLine(read.Reverse());
        }
    }
}
