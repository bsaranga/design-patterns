using System;
namespace abstractFactoryPattern
{
    public static class FactoryProvider
    {
        public static IAnimalFactory GetAnimalFactory(string factoryType)
        {
            if (factoryType.Contains("wild"))
            {
                return new WildAnimalFactory();

            } else

            if (factoryType.Contains("pet"))
            {
                return new PetAnimalFactory();

            } else
            
            {
                throw new ArgumentException("You need to pass either a 'wild' or 'pet' argument");
            }
        }
    }
}