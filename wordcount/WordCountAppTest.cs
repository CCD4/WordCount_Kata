using System;
using System.IO;
using NUnit.Framework;

namespace wordcount
{
    [TestFixture]
    public class WordCountAppTest
    {
        [Test]
        [Explicit]
        public void ReadWordsFromFile()
        {
            FileIO.stopWordsPath = @"C:\Users\svenk\Source\Repos\WordCount_Kata\wordcount\stopwords.txt";

            var path = @"C:\Users\svenk\Source\Repos\WordCount_Kata\wordcount\mytext.txt";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            WordCountApp.Run(new[] {path});

            Assert.AreEqual("Number of words: 5" + Environment.NewLine, stringWriter.ToString());
        }

        [Test]
        [Explicit]
        public void ReadWordsFromUi()
        {
            FileIO.stopWordsPath = @"C:\Users\svenk\Source\Repos\WordCount_Kata\wordcount\stopwords.txt";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var stringReader = new StringReader("Mary had a little lamb" + Environment.NewLine);
            Console.SetIn(stringReader);

            WordCountApp.Run(new string[0]);

            Assert.AreEqual("Enter text: Number of words: 5" + Environment.NewLine, stringWriter.ToString());
        }
    }
}