using System;

namespace Polymorphism
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }

        public virtual void Move()
        {
            Console.WriteLine("The animal moves");
        }
    }


    public class Dog : Animal
    {

        public override void MakeSound()
        {
            Console.WriteLine("Dog Barks");
        }

        public override void Move()
        {
            Console.WriteLine("Dog runs on 4 legs");
        }


    }

    public class Elephant : Animal
    {

        public override void MakeSound()
        {
            Console.WriteLine("Elephan Trumpets");
        }

        public override void Move()
        {
            Console.WriteLine("elephant walks slowly");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

           
            Animal myDog = new Dog();
            Animal myElephant = new Elephant();
            Animal genericAnimal = new Animal();

            Console.WriteLine(" ==== Polymorphism is in Action ====");
            Console.WriteLine("Dog Behaviour");
            myDog.MakeSound();
            myDog.Move();

            Console.WriteLine("Elephant Behaviour");
            myElephant.MakeSound();
            myElephant.Move();

            Console.WriteLine("Generic Behaviour");
            genericAnimal.MakeSound();
            genericAnimal.Move();

        }
    }
}
