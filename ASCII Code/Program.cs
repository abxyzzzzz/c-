using System;

namespace ASCII_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hello i am ASCAII code to DEC and vice versa");
                Console.WriteLine("press (sd) for  SYMBOL(ASCAII) to DEC");
                Console.WriteLine("press (ds) for  DEC to SYMBOL(ASCAII)");
                string read = Console.ReadLine();

                if (read == "sd" || read == "SD")
                {
                    Console.WriteLine("please enter the ASCAII code to convert into DEC");
                    string r = Console.ReadLine();
                    char character = r[0];
                    int asc = Convert.ToInt32(character);
                    Console.WriteLine($"OUPUT :{asc}");
                    
                }

                else if (read == "ds" || read == "DS")
                {
                    Console.WriteLine("please enter the DEC code to convert into ASSCAII");
                    string r = Console.ReadLine();
                    int g = Convert.ToInt32(r);
                    int f = g;
                    char chrctr = (char)g;
                    Console.WriteLine($"OUTPUT :{chrctr}");
                    
                }

                else
                {
                    Console.WriteLine("invalid output please try again");
                    continue;
                }
                break;
            }

        }
    }
}
