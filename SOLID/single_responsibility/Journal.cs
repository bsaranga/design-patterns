using System.IO;
using System.Collections.Generic;

namespace single_responsibility
{
    public class Journal
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

        public override string ToString()
        {
            return string.Join('\n', entries);
        }

        /// <summary>
        /// Single responsibility principle violation. The journal class should not be concerned with persisting the journal
        /// because if we want to add new persistence methods or change/fix any bugs related to persistence we will have to 
        /// modify the journal class. Therefore persistence is moved out of this class into PersistenceManager.cs
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="overwrite"></param>
        /*
        public void Save(string filename, bool overwrite = false)
        {
            File.WriteAllText(filename, ToString());
        }
        */
    }
}