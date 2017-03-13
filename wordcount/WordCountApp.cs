using System;

namespace wordcount
{
    public class WordCountApp
    {
        public static void Run(string[] args)
        {
            var text ="";
            ProcessCommandLine(args,
                fileName => text = FileIO.ReadTextFromFile(fileName),
                () => text = ConsoleUI.InputText());

            var count = DoCountWords(text);

            ConsoleUI.Output(count);
        }

        private static int DoCountWords(string text)
        {
            var stopwords = FileIO.FetchStopwords();
            var count = WordCount.CountWords(text, stopwords);
            return count;
        }

        private static void ProcessCommandLine(string[] args, Action<string> onFileNameFound, Action onNoFileNameFound)
        {
            if (args.Length == 1)
            {
                var fileName = args[0];
                onFileNameFound(fileName);
            }
            else
                onNoFileNameFound();
        }
    }
}