using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string maxKey = null;

        if (myList.Count == 0)
        {
            return null;
        }
        foreach (string key in myList.Keys)
        {
            if (maxKey == null || myList[maxKey] < myList[key])
            {
                maxKey = key;
            }
        }
        return maxKey;
    }
}
