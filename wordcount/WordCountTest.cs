using NUnit.Framework;

namespace wordcount
{
    [TestFixture]
    public class WordCountTest
    {
        [TestCase("A AB BCD", new[] { "A", "AB", "BCD" })]
        [TestCase("A  !-? $", new[] { "A" })]
        [TestCase("A!B", new[] { "A", "B" })]
        public void ExtractWords(string input, string[] expected)
        {
            var actual = Parser.ExtractWords(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveStopwords()
        {
            var words = new[] {"word", "stopword", "1"};
            var stopwords = new[] {"stopword", "2"};
            var expected = new[] {"word", "1"};
            var actual = WordCount.RemoveStopwords(words, stopwords);
            Assert.AreEqual(expected, actual);
        }
    }
}
