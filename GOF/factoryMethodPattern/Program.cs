using System;

namespace factoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory tigerFactory = new TigerFactory();
            IAnimal tiger = tigerFactory.CreateAnimal();
            tiger.AboutMe();

            AnimalFactory dogFactory = new DogFactory();
            IAnimal dog = dogFactory.CreateAnimal();
            dog.AboutMe();

            ConcreteAnimalFactory concreteAnimalFactory = new ConcreteAnimalFactory();
            var someAnimal = concreteAnimalFactory.CreateAnimalByName("a dog");
            someAnimal.AboutMe();
        }
    }
}
