using System;

namespace wordcount
{
    public class WordCountApp
    {
        public static void Run(string[] args)
        {
            var stopwords = FileIO.FetchStopwords();
            ChooseInputMethod(args, () =>
                {
                    var text = FileIO.ReadTextFromFile(args[0]);
                    var count = WordCount.CountWords(text, stopwords);
                    ConsoleUI.Output(count);
                },
                () =>
                {
                    var text = ConsoleUI.InputText();
                    var count = WordCount.CountWords(text, stopwords);
                    ConsoleUI.Output(count);
                });
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