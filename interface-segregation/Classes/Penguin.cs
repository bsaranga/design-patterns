using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_segregation.Classes
{
    public class Penguin : IWalkable, IEatable
    {
        public void Eat(string food)
        {
            Console.WriteLine($"The penguin eats {food}");
        }

        public void Walk(int distance)
        {
            Console.WriteLine($"The penguin walks {distance} miles");
        }
    }
}
