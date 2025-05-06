using System;

namespace giti
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Welcome to marks calculator of CBSE international school of class 10th");

                Console.WriteLine("-----------------------------------------------------------------------");

                Console.WriteLine("Please enter your marks of maths");
                Console.Write(":");
                string m = Console.ReadLine();
                int maths = Convert.ToInt32(m);
                if (maths <= 35)
                {
                    Console.WriteLine("Your failed");
                }
                else if (maths > 100)
                {
                    Console.WriteLine("Please enter valid marks");
                    continue;
                }
                else
                {
                    Console.WriteLine("Your passed");
                }


                Console.WriteLine("Please enter your marks of science");
                Console.Write(":");
                string s = Console.ReadLine();
                int science = Convert.ToInt32(s);
                if (science <= 35)
                {
                    Console.WriteLine("Your failed");
                }
                else if (science > 100)
                {
                    Console.WriteLine("Please enter valid marks");
                    continue;
                }
                else
                {
                    Console.WriteLine("Your passed");
                }


                Console.WriteLine("Please enter your marks of social stduies");
                Console.Write(":");
                string st = Console.ReadLine();
                int sst = Convert.ToInt32(st);
                if (sst <= 35)
                {
                    Console.WriteLine("Your failed");
                }
                else if (sst > 100)
                {
                    Console.WriteLine("Please enter valid marks");
                    continue;
                }
                else
                {
                    Console.WriteLine("Your passed");
                }

                Console.WriteLine("Please enter your marks of physcial education");
                Console.Write(":");
                string phy = Console.ReadLine();
                int pe = Convert.ToInt32(phy);
                if (pe <= 35)
                {
                    Console.WriteLine("Your failed");
                }
                else if (pe > 100)
                {
                    Console.WriteLine("Please enter valid marks");
                    continue;
                }
                else
                {
                    Console.WriteLine("Your passed");
                }

                Console.WriteLine("Please enter your marks of english");
                Console.Write(":");
                string e = Console.ReadLine();
                int eng = Convert.ToInt32(e);
                if (eng <= 35)
                {
                    Console.WriteLine("Your failed");
                }
                else if (eng > 100)
                {
                    Console.WriteLine("Please enter valid marks");
                    continue;
                }
                else
                {
                    Console.WriteLine("Your passed");
                }

                float per = ((float)(maths + science + eng + sst + pe) / 500);
                float percentage = (per * 100);
                //Console.WriteLine($"your pass/failure percentage is {per}");
                //Console.WriteLine(per);
                //Console.WriteLine($"your overall passing/fail percentage is {percentage:F2}% ");
                //Console.WriteLine($"your overall pass/fail percentage is {percentage}% ");
                percentage = (float)Math.Round(percentage, 2);
                Console.WriteLine(percentage);

                if (percentage < 36)
                {
                    Console.WriteLine($"Your failing percentage is {percentage}");
                }
                if (percentage >= 36)
                {
                    Console.WriteLine($"Your passing percentage is {percentage}");
                }

                if (percentage >= 1 && percentage < 35)
                {
                    Console.WriteLine("YOUR FAILED");
                }
                if (percentage >= 36 && percentage < 60)
                {
                    Console.WriteLine("Frist Division");
                }
                else if (percentage >= 60 && percentage < 80)
                {
                    Console.WriteLine("Second Division");
                }
                else if (percentage >= 80 && percentage < 90)
                {
                    Console.WriteLine("Thrid Division");
                }
                else if (percentage >= 90 && percentage <= 100)
                {
                    Console.WriteLine("Congratulations your a TOPPER!!!!!");
                }
                break;
            }

        }
    }
}