using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            // third try
            var t3 = UIInput.ReturnStringFromInput();
            t3 = RemoveSpecialCharacters.stringCleansed(t3);
            string[] resultArray = SplitString.stringSplitted(t3);
            int counter = CountStrings.stringsCount(resultArray);
            string cleansedString = RemoveSpecialCharacters.stringCleansed(t3);
            UIOutput.ReturnStringToOutput(counter);
            Console.ReadLine();
        }
    }

    public static class UIInput
    {
        private static string result; 

        public static string ReturnStringFromInput()
        {
            Console.WriteLine("third try / enter new string to split: ");
            return result = Console.ReadLine();
        }

    }

    public static class UIOutput
    {
        private static string result;

        public static void ReturnStringToOutput(int in_Int)
        {
            Console.WriteLine("words count: " + in_Int);
        }

    }

    public static class SplitString
    {
        private static string[] resultArray;

        public static string[] stringSplitted(string in_String)
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

    public static class RemoveSpecialCharacters
    {
        private static string resultString;

        public static string stringCleansed(string in_String)
        {
             return resultString = (Regex.Replace(in_String, "[^a-zA-Z ]+", "")).TrimEnd();
        }
    }

}
