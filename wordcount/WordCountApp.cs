using System;

namespace wordcount
{
    public class WordCountApp
    {
        public static void Run(string[] args)
        {
            ChooseInputMethod(args, () =>
                {
                    var text = FileIO.ReadTextFromFile(args[0]);
                    OutputWordCount(text);
                },
                () =>
                {
                    var text = ConsoleUI.InputText();
                    OutputWordCount(text);
                });
        }

        private static void OutputWordCount(string text)
        {
            var stopwords = FileIO.FetchStopwords();
            var count = WordCount.CountWords(text, stopwords);
            ConsoleUI.Output(count);
        }

        private static void ChooseInputMethod(string[] args, Action onReadFromFile, Action onReadFromConsole)
        {
            if (args.Length == 1)
                onReadFromFile();
            else
                onReadFromConsole();
        }
    }
}