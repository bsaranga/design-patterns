using System;
namespace simpleFactoryPattern
{
    public class Dog : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("I prefer barking");
        }
    }
}