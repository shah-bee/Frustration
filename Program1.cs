using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'stringAnagram' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY dictionary
     *  2. STRING_ARRAY query
     */

    public static List<int> stringAnagram(List<string> dictionary, List<string> query)
    {
        //find the in dictionary using query.
        var initial = CheckForSameLength(dictionary, query);
        return new List<int>();
    }

    private static bool IsAnagram()
    {
        return true;
    }

    private static IEnumerable<string> CheckForSameLength(List<string> dictionary, List<string> query)
    {
        foreach (var item in query)
        {
            var sameLength = dictionary.FirstOrDefault(o => o.Length.Equals(item.Length));
            yield return sameLength;
        }
    }

}

class Solution
{
    public static void Main1(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int dictionaryCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> dictionary = new List<string>();

        for (int i = 0; i < dictionaryCount; i++)
        {
            string dictionaryItem = Console.ReadLine();
            dictionary.Add(dictionaryItem);
        }

        int queryCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> query = new List<string>();

        for (int i = 0; i < queryCount; i++)
        {
            string queryItem = Console.ReadLine();
            query.Add(queryItem);
        }

        List<int> result = Result.stringAnagram(dictionary, query);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
