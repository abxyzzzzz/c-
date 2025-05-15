using System;

namespace Private_Public_Program
{

    class Orange
    {

        private int numb1;
        private int numb2;

        public int number1
        {
            get { return numb1; }
            set { numb1 = value; }
        }

        public int number2
        {
            get { return numb2; }
            set { numb2 = value; }
        }

        public Orange()
        {
            numb1 = 0;
            numb2 = 0;
        }

        public int add()
        {
            return numb1 + numb2;
        }

        public int minus()
        {
            return numb1 - numb2;
        }

        public int multiply()
        {
            return numb1 * numb2;
        }
        public int divide()
        {
            return numb1 / numb2;
        }

        public int BODMAS()
        {
            return numb1 + (numb1 * numb2);
        }         


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Please enter your number 1 value ");
            string n1 = Console.ReadLine();
            int no1 = Convert.ToInt32(n1);

            Console.WriteLine("Please enter your number 2 value ");
            string n2 = Console.ReadLine();
            int no2 = Convert.ToInt32(n2);


            Orange obj = new Orange();
            obj.number1 = no1;
            obj.number2 = no2;
            Console.WriteLine(obj.number1);
            Console.WriteLine(obj.number2);
            Console.WriteLine($"After adding the values: {obj.add()}");
            Console.WriteLine($"After subtracting the values: {obj.minus()}");
            Console.WriteLine($"After multiplying the values: {obj.multiply()}");
            Console.WriteLine($"After dividng the values: {obj.divide()}");
            Console.WriteLine($"After BODMAS the values: {obj.BODMAS()}");
            


        }
    }
}
