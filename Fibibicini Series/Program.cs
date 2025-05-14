using System;

namespace series
{
    class Program
    {
        public static void Series()
        {
            Console.Clear();
            Console.WriteLine("Please enter your number ");
            string num=Console.ReadLine();
            int no=Convert.ToInt32(num);
            Console.WriteLine("---------OUPUT----------");

            if (no < 1)
            {
                Console.WriteLine("not possible");
                return;
            }
            int pre1 = 1;
            int pre2 = 0;

            for (int i = 1; i <= no; i++)
            {
                if (no > 2)
                {
                    int current = pre1 + pre2;
                    pre1 = pre2;
                    pre2 = current;
                    Console.WriteLine(current);
                }
                else if (i == 1)
                {
                    Console.WriteLine($"{pre2}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"{pre1}");
                }
            }
        }
        static void Main(string[] args)
        {
            Series();
            Console.Write("---------ENDPUT----------");
            Console.WriteLine("done");

        }
    }
}
