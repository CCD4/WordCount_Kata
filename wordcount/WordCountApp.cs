namespace wordcount
{
    public class WordCountApp
    {
        public static void Run()
        {
            string text = ConsoleUI.InputText();
            int count = WordCount.CountWords(text);
            ConsoleUI.Output(count);
        }
    }
}
