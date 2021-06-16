using System;

namespace simpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFactory simpleFactory = new SimpleFactory();

            IAnimal animal = simpleFactory.CreateAnimal();
            animal.AboutMe();
        }
    }
}
