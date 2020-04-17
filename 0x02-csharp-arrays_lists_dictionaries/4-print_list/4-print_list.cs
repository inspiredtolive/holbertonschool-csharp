using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> list;
        string sep = "";

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        list = new List<int>();
        for (int i = 0; i < size; i++)
        {
            list.Add(i);
            Console.Write("{0}{1}", sep, i);
            sep = " ";
        }
        Console.WriteLine();
        return list;
    }
}
