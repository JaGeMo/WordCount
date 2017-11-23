using System;
using System.Text.RegularExpressions;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            // first try
            const string t1 = "To be or not to be, that is the question.";
            Console.WriteLine("first try (fixed string): To be or not to be, that is the question.");
            Console.WriteLine(WordCounting.CountWords(t1));
            // second try
            Console.WriteLine("second try / enter new string: ");
            string t2 = Console.ReadLine();
            Console.WriteLine(WordCounting.CountWords(t2));
            // third try
            Console.WriteLine("third try / enter new string to split: ");
            string t3 = Console.ReadLine();
            string[] resultArray = SplitString.stringSplitted(t3);
            foreach (string result in resultArray)
            {
                Console.WriteLine(result);
            }
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
    
    public static class SplitString
    {
        private static string[] resultArray;

        public static string[] stringSplitted( string in_String)
        {
            string[] resultArray = in_String.Split(' ');
            return resultArray;
        }

    }
}
