using System;
using System.Text.RegularExpressions;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //// first try
            //const string t1 = "To be or not to be, that is the question.";
            //Console.WriteLine("first try (fixed string): To be or not to be, that is the question.");
            //Console.WriteLine(DirectWordCounting.CountWords(t1));
            //// second try
            //Console.WriteLine("second try / enter new string: ");
            //string t2 = Console.ReadLine();
            //Console.WriteLine(DirectWordCounting.CountWords(t2));


            // third try
            Console.WriteLine("third try / enter new string to split: ");
            string t3 = Console.ReadLine();
            string[] resultArray = SplitString.stringSplitted(t3);
            int count = CountStrings.stringsCount(resultArray);
            Console.WriteLine("number of words: " + count.ToString());
            Console.ReadLine();
        }
    }
    
    //public static class DirectWordCounting
    //{
    //    public static int CountWords(string s)
    //    {
    //        MatchCollection collection = Regex.Matches(s, @"[\S]+");
    //        return collection.Count;
    //    }

    //}
    
    public static class SplitString
    {
        private static string[] resultArray;

        public static string[] stringSplitted( string in_String)
        {
            string[] resultArray = in_String.Split(' ');
            return resultArray;
        }

    }

    public static class CountStrings
    {
        private static int result = 0;

        public static int stringsCount(string[] in_stringArray)
        {
            foreach (string word in in_stringArray)
            {
                result++;
            }
            
            return result;
        }
    }


}
