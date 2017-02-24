namespace wordcount
{
    public class WordCountApp
    {
        public static void Run()
        {
            string text = ConsoleUI.InputText();
            string[] stopwords = FileIO.FetchStopwords();
            int count = WordCount.CountWords(text, stopwords);
            ConsoleUI.Output(count);
        }
    }
}
