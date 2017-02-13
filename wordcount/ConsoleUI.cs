using System;

namespace wordcount
{
    public class ConsoleUI
    {
        public static string InputText()
        {
            Console.Write("Enter text: ");
            return Console.ReadLine();
        }

        public static void Output(int wordCount)
        {
            Console.WriteLine($"Number of words: {wordCount}");
        }
    }
}
