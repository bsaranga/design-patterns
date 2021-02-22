using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GClass<int, string, float> gClass = new GClass<int, string, float>(4, "Hello", 3.14f);
            Console.WriteLine(gClass.GetType());

            gClass.SetLife(5.612f);
            gClass.SetLife("sjhdfkj");
            gClass.SetLife(42);
        }
    }
}
