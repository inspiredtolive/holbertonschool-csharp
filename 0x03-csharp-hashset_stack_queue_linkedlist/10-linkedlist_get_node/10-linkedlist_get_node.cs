using System;
using System.Collections.Generic;
class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node;

        if (n < 0 || n > myLList.Count - 1)
        {
            return 0;
        }
        node = myLList.First;
        for (; n > 0; node = node.Next, n--)
            ;
        return node.Value;
    }
}