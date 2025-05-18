using System;

namespace Simple_Intrest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello welcome to Simple Intest Calclator");
            Console.WriteLine("please enter your prcipal amount");
            string p = Console.ReadLine();
            double a = Convert.ToDouble(p);
            Console.WriteLine("Great!!");

            Console.WriteLine("Now enter the Annual Intrest Rate");
            string r = Console.ReadLine();
            double i = Convert.ToDouble(r);
            Console.WriteLine("Great!!");

            Console.WriteLine("Now enter the Time period (in years)");
            string t = Console.ReadLine();
            double pi = Convert.ToDouble(t);
            Console.WriteLine("Great!!");

           double si = (a * i * pi) / 100;
            
            Console.WriteLine($"your amount is : {si}");




        }
    }
}
