using System;
using System.Collections.Generic;
using System.Globalization;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blackList = StopWords.ReadBlackListWords();
            var t3 = UIInput.ReturnStringFromInput();
            var rawList = SplitString.StringSplitted(t3);
            var cleansedList = StopWords.ReturnCleansedString(blackList, rawList);

            Console.WriteLine(CountStrings.StringsCountFromList(cleansedList));
        }
    }
}
