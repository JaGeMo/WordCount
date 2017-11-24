using System;
using System.Collections.Generic;
using System.Globalization;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var blackList = StopWords.ReadBlackListWords();

            var inputString = UIInput.ReturnStringFromInput();

            var splitList = SplitString.StringSplitted(inputString);

            var cleansedList = StopWords.ReturnCleansedString(blackList, splitList);

            Console.WriteLine(CountStrings.StringsCountFromList(cleansedList));
        }
    }
}