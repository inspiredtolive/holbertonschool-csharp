﻿using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> isEvenList = new List<bool>();

        foreach (int num in myList)
        {
            if (num % 2 == 0)
            {
                isEvenList.Add(true);
            }
            else
            {
                isEvenList.Add(false);
            }
        }
        return isEvenList;
    }
}