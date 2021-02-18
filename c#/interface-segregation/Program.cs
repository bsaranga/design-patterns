using interface_segregation.Classes;

namespace interface_segregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Penguin penguin = new Penguin();
            penguin.Eat("Tuna");
            penguin.Walk(21);

            Eagle eagle = new Eagle();
            eagle.Fly(12, 45);
            eagle.Eat("Wormy");
            eagle.Walk(1);
        }
    }
}
