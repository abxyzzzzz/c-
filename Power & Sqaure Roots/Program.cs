using System;

namespace Power___Sqaure_Roots
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("---Hello I Can Calculate EXPONENTS and SQUARE ROOTS----");
                Console.WriteLine("press E for Exoponents and S for Square Roots");
                string read = Console.ReadLine();

                if (read == "e" || read == "E")
                {
                    Console.WriteLine("please enter your base ");
                    string basem = Console.ReadLine();
                    double b = Convert.ToDouble(basem);

                    Console.WriteLine("please enter your power");
                    string power = Console.ReadLine();
                    double p = Convert.ToDouble(power);
                    double pow = Math.Pow(b, p);
                    
                    Console.WriteLine($"OUTPUT: {pow}");
                }

                else if (read == "S" || read == "s")
                {
                    Console.WriteLine("Please enter your sqaured root");
                    string root = Console.ReadLine();
                    double s = Convert.ToDouble(root);
                    double Square = Math.Sqrt(s);
                    Console.WriteLine($"OUTPUT : {Square}");
                }

                else
                {
                    Console.WriteLine("ERORR");
                    continue;
                }
                break;
            }
        }
    }
}
