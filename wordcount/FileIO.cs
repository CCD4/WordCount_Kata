using System.IO;

namespace wordcount
{
    class FileIO
    {
        internal static string stopWordsPath = "stopwords.txt";

        public static string[] FetchStopwords()
        {
            return File.ReadAllLines(stopWordsPath);
        }

        public static string ReadTextFromFile(string filename)
        {
            return File.ReadAllText(filename);
        }
    }
}
