using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public static class StopWords
{
    private static string[] blackList;

    public static string[] ReadBlackListWords()
    {
        string path = @"C:\Temp\Sicherungen\CleanCode\StopWords.txt";

        if (File.Exists(path))
        {
            blackList = File.ReadAllLines(path);
        }
        else
        {
            Console.WriteLine("file not found .. ");
        }

        return blackList;
    }

    public static List<string> ReturnCleansedString(string[] in_BlackList, List<string> in_RawStringList)
    {
        foreach (string blackListString in in_BlackList)
        {
            if (in_RawStringList.Any(s => s.Contains(blackListString)))
            {
                in_RawStringList.Remove(blackListString);
            }
        }

        return in_RawStringList;
    }
}