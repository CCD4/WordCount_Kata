using System.IO;

namespace wordcount
{
    class FileIO
    {
        public static string[] FetchStopwords()
        {
            return File.ReadAllLines("stopwords.txt");
        }

        public static string ReadTextFromFile(string filename)
        {
            return File.ReadAllText(filename);
        }
    }
}
