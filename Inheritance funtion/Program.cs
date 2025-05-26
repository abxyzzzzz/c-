using System;
using Inheritance_funtion;

namespace Inheritance_funtion
{

    public class vehicle
    {
        protected string name;
        public vehicle(string carname)
        {
            this.name = carname;
        }
        public void AC()
        {
            Console.WriteLine($"{name} is turning on AC");
        }
        public void Brake()
        {
            Console.WriteLine($"{name} is pressing Brake");
        }
    }

    public class audi : vehicle
    {
        public audi(string name) : base(name)
        {
            //constructur
        }
        public void Ai()
        {
            Console.WriteLine($"{name} ai has been activated");
        }
        public void SportsMode()
        {
            Console.WriteLine($"{name} SportsMode has been activated");
        }
    }
    public class maruti : vehicle
    {
        public maruti(string name) : base(name)
        {
            //constructur
        }
        public void ManualTransmission()
        {
            Console.WriteLine($"{name} ManualTransmission is being used ");
        }
        public void Mileage()
        {
            Console.WriteLine($"{name} Mielage is good");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AUDI EXAMPLE");
            audi newaudi = new audi("audi A4");
            newaudi.Ai();
            newaudi.AC();
            newaudi.Brake();
            newaudi.SportsMode();

            Console.WriteLine();

            Console.WriteLine("MARUTI EXAMPLE");
            maruti newmaruti = new maruti("Maruti 800");
            newmaruti.ManualTransmission();
            newmaruti.Mileage();
            newmaruti.Brake();
            newmaruti.AC();


        }
    }
}
