using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] array;
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        array = new int[size];
        for (int i = 0; i < size; i++)
        {
            if (i > 0)
            {
                Console.Write(" ");
            }
            Console.Write(i);
            array[i] = i;         
        }
        Console.WriteLine();
        return array;
    }
}
