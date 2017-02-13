using System.Collections.Generic;
using System.Linq;

namespace wordcount
{
    public class WordCount
    {
        public static int CountWords(string text)
        {
            IEnumerable<string> words = Parser.ExtractWords(text);
            words = FilterStopwords(words);
            return Count(words);
        }

        private static int Count(IEnumerable<string> words)
        {
            return words.Count();
        }

        private static IEnumerable<string> FilterStopwords(IEnumerable<string> words)
        {
            var stopwords = FileIO.FetchStopwords();
            return RemoveStopwords(words, stopwords);
        }

        public static string[] RemoveStopwords(IEnumerable<string> words, string[] stopwords)
        {
            return words.Except(stopwords).ToArray();
        }
    }
}
