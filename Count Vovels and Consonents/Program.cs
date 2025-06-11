using System;

namespace Count_Vovels_and_Consonents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Please Enter and i will count Vovels And Consonents ");
            string vc = Console.ReadLine();
            int len = vc.Length;
            int Vovels = 0;
            int Consonents = 0;

            for (int i = 0; i < len; i++)
            {
                if (vc[i] == 'a' || vc[i] == 'e' || vc[i] == 'i' ||
                    vc[i] == 'o' || vc[i] == 'u')
                {
                    Vovels++;
                }
                else
                {
                    Consonents++;
                }
            }
            Console.WriteLine($"VOVELS ARE:{Vovels}");
            Console.WriteLine($"CONSONENTS ARE:{ Consonents}");
        }
    }
}
