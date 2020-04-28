using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int val;

        if (myLList.Count == 0)
        {
            return (0);
        }
        val = myLList.First.Value;
        myLList.RemoveFirst();
        return val;
    }
}
