using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_segregation.Classes
{
    public class Eagle : IFlyable, IEatable, IWalkable
    {
        public void Eat(string food)
        {
            Console.WriteLine($"The eagle eats {food}");
        }

        public void Fly(int altitude, int distance)
        {
            Console.WriteLine($"The eagle flies {distance} miles at an altitude of {altitude}");
        }

        public void Walk(int distance)
        {
            Console.WriteLine($"The eagle walks {distance} miles");
        }
    }
}
