using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string maxKey = "None";

        if (myList.Count == 0)
        {
            return maxKey;
        }
        foreach (string key in myList.Keys)
        {
            if (maxKey == "None" || myList[maxKey] < myList[key])
            {
                maxKey = key;
            }
        }
        return maxKey;
    }
}
