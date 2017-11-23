using System;
using System.Text.RegularExpressions;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Versuch
            const string t1 = "To be or not to be, that is the question.";
            Console.WriteLine("first try (fixed string): To be or not to be, that is the question.");
            Console.WriteLine(WordCounting.CountWords(t1));

            Console.WriteLine("second try / enter new string: ");
            string t2 = Console.ReadLine();
            Console.WriteLine(WordCounting.CountWords(t2));

            Console.ReadLine();

        }
    }


    public static class WordCounting
    {
        public static int CountWords(string s)
        {
            MatchCollection collection = Regex.Matches(s, @"[\S]+");
            return collection.Count;
        }

    }
}
