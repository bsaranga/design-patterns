namespace factoryMethodPattern
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal();
        public abstract IAnimal CreateAnimalByName(string animalType);
    }
}