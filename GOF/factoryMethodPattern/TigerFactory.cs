namespace factoryMethodPattern
{
    public class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Tiger();
        }

        public override IAnimal CreateAnimalByName(string animalType)
        {
            throw new System.NotImplementedException();
        }
    }
}