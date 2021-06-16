using System;
namespace simpleFactoryPattern
{
    public class SimpleFactory
    {
        public IAnimal CreateAnimal()
        {
            IAnimal outAnimal = null;
            Console.Write("Enter choice of animal to create: ");

            string b1 = Console.ReadLine();
            int input;

            if(int.TryParse(b1, out input))
            {
                Console.WriteLine($"You've entered {input}");

                switch(input)
                {
                    case 0:
                        outAnimal = new Dog();
                        break;
                    case 1:
                        outAnimal = new Tiger();
                        break;
                    default:
                        Console.WriteLine("You must either enter 0 or 1");
                        throw new ApplicationException("Unknown animal cannot be instantiated");
                }
            }

            return outAnimal;
        }
    }
}