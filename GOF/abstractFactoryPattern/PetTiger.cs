using System;
namespace abstractFactoryPattern
{
    public class PetTiger : ITiger
    {
        public void AboutMe()
        {
            Console.WriteLine("I'm a pet tiger in the circus");
        }
    }
}