namespace abstractFactoryPattern
{
    public interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();
    }
}