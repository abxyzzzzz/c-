using System;

namespace Armstrong_And_Pl
{
    class Program
    {

        public static bool IsArmstrong(int number)
        {
            int originalNumber = number;
            int sum = 0;
            int numDigits = number.ToString().Length;

            while (number > 0)
            {
                int digit = number % 10;
                Console.WriteLine("digit: " + digit.ToString());
                sum += (int)Math.Pow(digit, numDigits);
                Console.WriteLine("SUM :" + sum);
                number /= 10;
                Console.WriteLine("numer:" + number);

            }
            Console.WriteLine(sum);

            return sum == originalNumber;
        }

        public static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversed = 0;

            while (number > 0)
            {
                int digit = number % 10;
                Console.WriteLine("digit: "+digit);
                reversed = reversed * 10 + digit;
                Console.WriteLine("revsed: " + reversed);
                number /= 10;
                Console.WriteLine("number: "+number);
            }
            Console.WriteLine("rev: "+reversed);

            return originalNumber == reversed;
        }

        static void Main(string[] args)
        {
            // Console.WriteLine(IsArmstrong(153));
            Console.WriteLine(IsPalindrome(121));
        }
    }
}
