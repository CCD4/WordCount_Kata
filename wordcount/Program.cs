using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace wordcount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = InputText();
            int count = CountWords(text);
            Output(count);
        }

        private static void Output(int wordCount)
        {
            Console.WriteLine($"Number of words: {wordCount}");
        }

        private static int CountWords(string text)
        {
            IEnumerable<string> words = ExtractWords(text);
            words = FilterStopwords(words);
            return Count(words);
        }

        private static IEnumerable<string> FilterStopwords(IEnumerable<string> words)
        {
            var stopwords = FetchStopwords();
            return RemoveStopwords(words, stopwords);
        }

        private static int Count(IEnumerable<string> words)
        {
            return words.Count();
        }

        internal static IEnumerable<string> ExtractWords(string text)
        {
            var rgx = new Regex("[^a-zA-Z]");
            text= rgx.Replace(text, " ");
            return text.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        }

        private static string InputText()
        {
            Console.Write("Enter text: ");
            return Console.ReadLine();
        }

        public static string[] RemoveStopwords(IEnumerable<string> words, string[] stopwords)
        {
            return words.Except(stopwords).ToArray();
        }

        private static string[] FetchStopwords()
        {
            return File.ReadAllLines("stopwords.txt");
        }
    }
}
