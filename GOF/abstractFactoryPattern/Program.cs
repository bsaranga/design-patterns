using System;

namespace abstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var wildFactory = FactoryProvider.GetAnimalFactory("wild");
            var petFactory = FactoryProvider.GetAnimalFactory("pet");

            var wildDog = wildFactory.GetDog();
            var wildTiger = wildFactory.GetTiger();
            var petDog = petFactory.GetDog();
            var petTiger = petFactory.GetTiger();

            wildDog.AboutMe();
            wildTiger.AboutMe();
            petDog.AboutMe();
            petTiger.AboutMe();
        }
    }
}
