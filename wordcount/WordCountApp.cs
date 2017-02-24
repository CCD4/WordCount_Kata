using System.IO;

namespace wordcount
{
    public class WordCountApp
    {
        public static void Run(string[] args)
        {
            string text = GetText(args);
            string[] stopwords = FileIO.FetchStopwords();
            int count = WordCount.CountWords(text, stopwords);
            ConsoleUI.Output(count);
        }

        private static string GetText(string[] args)
        {
            if (args.Length == 1)
                return FileIO.ReadTextFromFile(args[0]);
            else
            {
                return ConsoleUI.InputText();
            }
        }
    }
}
