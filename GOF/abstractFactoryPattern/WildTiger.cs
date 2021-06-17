using System;
namespace abstractFactoryPattern
{
    public class WildTiger : ITiger
    {
        public void AboutMe()
        {
            Console.WriteLine("I'm a wild tiger");
        }
    }
}