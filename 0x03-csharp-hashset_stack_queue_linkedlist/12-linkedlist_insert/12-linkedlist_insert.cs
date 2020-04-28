using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
		for (LinkedListNode<int> cur = myLList.First; cur != null; cur = cur.Next)
		{
			if (n < cur.Value)
			{
				return myLList.AddBefore(cur, n);
			}
		}
		return myLList.AddLast(n);
    }
}
