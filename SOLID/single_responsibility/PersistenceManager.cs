using System.IO;
namespace single_responsibility
{
    public class PersistenceManager
    {
        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            {
                
                File.WriteAllText(filename, journal.ToString());

            } else {

                File.AppendAllText(filename, journal.ToString());

            }
        }
    }
}