using System;

namespace diffrent_swap
{
    class Program
    {

        public void Add(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after swap using two variables");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public void Add(int a, int b, int c)
        {
            c = a;
            a = b;
            b = c;
            Console.WriteLine("after swap using three varibales");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void Main(string[] args)
        {

            Program obj = new Program();
            obj.Add(10, 20);
            obj.Add(10, 20, 0);


        }
    }
}
