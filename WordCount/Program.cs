using System;
using System.Collections.Generic;
using System.Globalization;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args )
        {
            var blackList = StopWords.ReadBlackListWords();

            if (args.Length == 0)
            {
                args = new string[] { "" };
            }

            var inputString = UIInput.ProcessInput(args[0]);
            
            var splitList = Splitter.SplitString(inputString);

            var cleansedList = StopWords.ReturnCleansedString(blackList, splitList);

            Console.WriteLine(CountStrings.StringsCountFromList(cleansedList));
        }
    }
}