using System;

namespace Categorizes_Person_height_as_tall_or_short
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello Im height teller wether your tall or short or average");
            Console.WriteLine("Please tell your height in cm only");
            string read = Console.ReadLine();
            float value = Convert.ToSingle(read);

            if (value <= 150)
            {
                Console.WriteLine("Your Short");

            }
            else if (value >= 151 && value <= 165)
            {
                Console.WriteLine("Your Average");
            }
            else if (value >= 166 && value <= 175)
            {
                Console.WriteLine("Your tall");
            }
            else if (value >= 176 && value <= 210)
            {
                Console.WriteLine("YOU HAVE INSANE GENETICS!!!!!");
            }
            else
            {
                Console.WriteLine("ERROR:UNEXPECTED HEIGHT");
            }

        }
    }
}
