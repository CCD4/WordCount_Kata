using System;
using System.IO;
using NUnit.Framework;

namespace wordcount
{
    [TestFixture]
    public class WordCountAppTest
    {
        [SetUp]
        public void SetUp()
        {
            var currentContextWorkDirectory = TestContext.CurrentContext.TestDirectory;
            Environment.CurrentDirectory = currentContextWorkDirectory;
        }

        [Test]
        public void ReadWordsFromFile()
        {
            var path = @"mytext.txt";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            WordCountApp.Run(new[] {path});

            Assert.AreEqual("Number of words: 5" + Environment.NewLine, stringWriter.ToString());
        }

        [Test]
        public void ReadWordsFromUi()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var stringReader = new StringReader("Mary had a little lamb" + Environment.NewLine);
            Console.SetIn(stringReader);

            WordCountApp.Run(new string[0]);

            Assert.AreEqual("Enter text: Number of words: 5" + Environment.NewLine, stringWriter.ToString());
        }
    }
}