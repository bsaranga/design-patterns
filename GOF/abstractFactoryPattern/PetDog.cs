using System;
namespace abstractFactoryPattern
{
    public class PetDog : IDog
    {
        public void AboutMe()
        {
            Console.WriteLine("I'm a pet dog");
        }
    }
}