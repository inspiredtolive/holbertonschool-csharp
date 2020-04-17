using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int max = int.MinValue;
        
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
			return -1;
        }
        foreach (int num in myList)
        {
            if (max < num)
            {
                max = num;
            }
        }
        return max;
    }
}
