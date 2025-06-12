using System;
using System.Linq;

namespace Remove_Spaces_from_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello IM leading space remover i will remove your leading space");
            Console.WriteLine("Please enter your text");

            string text = Console.ReadLine();
            Console.WriteLine($"OUTPUT: {text.Trim()}");
        }
    }
}
