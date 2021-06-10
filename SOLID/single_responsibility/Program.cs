using System;

namespace single_responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var persist = new PersistenceManager();

            var journal = new Journal();
            journal.AddEntry("Hello world");
            journal.AddEntry("It's a nice day");

            persist.SaveToFile(journal, "./journal.txt");
        }
    }
}
