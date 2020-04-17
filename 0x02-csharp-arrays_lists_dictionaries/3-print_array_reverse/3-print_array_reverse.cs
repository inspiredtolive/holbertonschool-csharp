using System;

class Array
{
    public static void Reverse(int[] array)
    {
        String sep = "";
        if (array != null)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}{1}", sep, array[i]);
                sep = " ";
            }
        }
        Console.WriteLine();
    }
}
