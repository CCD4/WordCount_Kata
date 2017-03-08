using System.Collections.Generic;
using System.Linq;

namespace wordcount
{
    public class WordCount
    {
        public static int CountWords(string text, string[] stopwords)
        {
            IEnumerable<string> words = Parser.ExtractWords(text);
            words = RemoveStopwords(words, stopwords);
            return Count(words);
        }

        private static int Count(IEnumerable<string> words)
        {
            return words.Count();
        }
        
        internal static string[] RemoveStopwords(IEnumerable<string> words, string[] stopwords)
        {
            return words.Except(stopwords).ToArray();
        }
    }
}
