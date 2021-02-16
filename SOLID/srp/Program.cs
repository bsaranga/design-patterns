using System.IO;
using System.Collections.Generic;

namespace srp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            myJournal.AddEntry("Hello world");
            myJournal.AddEntry("What a good day");
            myJournal.AddEntry("Oops");
            myJournal.RemoveEntry(2);
            
            PersistenceManager manager = new PersistenceManager();
            manager.SaveToFile(myJournal, "myjournal.txt", true);
        }
    }

    class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public void AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        /*
        Single Responsibility Principle:
        Each class has only one responsibility and therefore only one reason to change.
        Applies to methods as well. Below in a seperate class we handle data persistence to
        honor SRP.
        */
    }

    class PersistenceManager
    {
        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if(overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename, journal.ToString());

                // Obviously the ToString method writes the object name to the file, but the goal here is to portray design patterns not functionality
            }
        }
    }

    /*
    A single monolithic class that handles everything is called a 'God object' and it must be avoided at all costs
    */
}
