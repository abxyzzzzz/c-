using System;

namespace swap_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello im number swapper ");
            Console.WriteLine("------------------------");
            Console.WriteLine("press any enter/anykey to continue");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char keyChar = keyInfo.KeyChar;
            Console.WriteLine("");
            Console.WriteLine("great lets continue");
            Console.WriteLine("------------------------");

            Console.WriteLine("please enter the value/number for A:");
            string no = Console.ReadLine();
            int a = Convert.ToInt32(no);


            Console.WriteLine("please enter the value/number for B:");
            string no2 = Console.ReadLine();
            int b = Convert.ToInt32(no2);


            Console.WriteLine("please enter the value/number for C:");
            string no3 = Console.ReadLine();
            int c = Convert.ToInt32(no3);

            a=a+b+c;
            c=a-b-c;
            b=a-b-c;
            a=a-b-c;
            
            
           
        
            

            Console.WriteLine("After swapping");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
