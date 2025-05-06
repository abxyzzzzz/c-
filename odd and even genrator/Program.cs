using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to odd and even genrator ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("please enter you nummber");
            string number = Console.ReadLine();
            int no = Convert.ToInt32(number);

            if (no%2==0)
            {
                Console.WriteLine("even");
            }
            else
                {
                    Console.WriteLine("odd");
                }
            }
        }
    }


