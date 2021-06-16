namespace factoryMethodPattern
{
    public class DogFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }

        public override IAnimal CreateAnimalByName(string animalType)
        {
            throw new System.NotImplementedException();
        }
    }
}