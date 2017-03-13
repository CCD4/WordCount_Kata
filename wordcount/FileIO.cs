using System.IO;

namespace wordcount
{
    class FileIO
    {
        private const string StopWordsPath = "stopwords.txt";

        public static string[] FetchStopwords()
        {
            return File.ReadAllLines(StopWordsPath);
        }

        public static string ReadTextFromFile(string filename)
        {
            return File.ReadAllText(filename);
        }
    }
}
