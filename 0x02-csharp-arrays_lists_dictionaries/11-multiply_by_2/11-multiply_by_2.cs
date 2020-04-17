using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> doubleDict = new Dictionary<string, int>();

        foreach (string key in myDict.Keys)
        {
            doubleDict.Add(key, myDict[key] * 2);
        }
        return doubleDict;
    }
}