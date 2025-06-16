using System;

namespace Capitilize_Frist_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Clear();
            Console.WriteLine("Enter your text and i will make the frist word capital");
            string read = Console.ReadLine();

            string sub = read.Substring(0,1).ToUpper();
            string rest = read.Substring(1);
            Console.WriteLine(sub+rest);
        }
    }
}
