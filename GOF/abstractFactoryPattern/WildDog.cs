using System;
namespace abstractFactoryPattern
{
    public class WildDog : IDog
    {
        public void AboutMe()
        {
            Console.WriteLine("I'm a wild dog");
        }
    }
}