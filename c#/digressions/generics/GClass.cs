using System;

namespace generics
{
    public class GClass<T,P,G>
    {
        public static T Prop1 { get; set; }
        public static P Prop2 { get; set; }
        public static G Prop3 { get; set; }

        public GClass()
        {

        }

        public GClass(T t, P p, G g)
        {
            Prop1 = t;
            Prop2 = p;
            Prop3 = g;
        }

        public static void GetTheType()
        {
            Console.WriteLine($"{typeof(T)}\n{typeof(P)}\n{typeof(G)}");
        }

        public void SetLife(T input)
        {
            Prop1 = input;
        }

        public void SetLife(P input)
        {
            Prop2 = input;
        }

        public void SetLife(G input)
        {
            Prop3 = input;
        }

        public int GetLife()
        {
            return 1;
        }
    }
}
