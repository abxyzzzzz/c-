using System;

namespace Count_characters__words
{
    class Program
    {
        static void Main(string[] args)
        {
            //chracters
            Console.WriteLine("Enter your words and i will count it");
            string read = Console.ReadLine();
            string output =read.Replace(" ", "");
            int read1 = output.Length;
            int count = 0;
            for (int i = 0; i < read1; i++)
            {
                count++;

            }
            Console.WriteLine($"THE chracters ARE:{count}");
            
            
            //words
            string chr= Console.WriteLine(read.Replace(" ", "/t"));
            Console.WriteLine(chr.Length("/t"));




        }
    }
}
