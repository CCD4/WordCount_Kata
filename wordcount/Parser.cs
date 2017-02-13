using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace wordcount
{
    public class Parser
    {
        public static IEnumerable<string> ExtractWords(string text)
        {
            var rgx = new Regex("[^a-zA-Z]");
            text = rgx.Replace(text, " ");
            return text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
