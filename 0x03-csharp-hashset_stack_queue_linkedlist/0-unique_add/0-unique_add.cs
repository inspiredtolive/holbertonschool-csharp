using System;
using System.Collections.Generic;

class List
{
    // Main - entry point
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        HashSet<int> uniqueNums = new HashSet<int>(myList);

        foreach (int num in uniqueNums)
        {
            sum += num;
        }
        return sum;
    }
}