using System;
namespace simpleFactoryPattern
{
    public class Tiger : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("I prefer hunting");
        }
    }
}