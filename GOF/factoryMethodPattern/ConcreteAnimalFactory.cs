using System;
namespace factoryMethodPattern
{
    public class ConcreteAnimalFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            throw new System.NotImplementedException();
        }

        public override IAnimal CreateAnimalByName(string animalType)
        {
            if (animalType.Contains("dog"))
            {
                return new Dog();
            }
            else if (animalType.Contains("tiger"))
            {
                return new Tiger();
            }
            else {
                throw new ArgumentException("You need to pass either a dog or a tiger argument");
            }
        }
    }
}