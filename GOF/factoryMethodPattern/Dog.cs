using System;
namespace factoryMethodPattern
{
    public class Dog : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("Barks, woof woof");
        }
    }
}