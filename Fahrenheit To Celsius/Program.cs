using System;

namespace Fahrenheit_To_Celsius
{
    class Program
    {


        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hello im  fareinheit to celcuis converter and vice versa!");
                Console.WriteLine("press cf to convert celciuis to farnheit");
                Console.WriteLine("press fc to convert farnheit to celciuis");
                Console.WriteLine("---------------------------------------------");
                Console.Write(":");

                string p = Console.ReadLine();
                

                if (p == "cf")
                {
                    Console.WriteLine("Please enter your celcuis to convert to farnhiht");
                    string read = Console.ReadLine();
                    double c = Convert.ToDouble(read);
                    double cf = (c * 9 / 5) + 32;
                    Console.WriteLine($"your OUTPUT : {cf}");

                }

                else if (p == "fc")
                {
                    Console.WriteLine("Please enter your farnehit to convert to celcuis");
                    string readt = Console.ReadLine();
                    double f = Convert.ToDouble(readt);
                    double fc = (f - 32) * 5f/9f;
                    Console.WriteLine($"your OUTPUT : {fc}");
                }

                else
                {
                    Console.WriteLine("Eror");
                    continue;

                }
                break;
            }


        }
    }
}
