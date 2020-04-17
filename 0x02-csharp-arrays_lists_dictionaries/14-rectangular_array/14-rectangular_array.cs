using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[5, 5];

        array[2, 2] = 1;
        for (int i = 0; i < 5; i++)
        {
            string sep = "";
            for (int j = 0; j < 5; j++)
            {
                Console.Write("{0}{1}", sep, array[i, j]);
                sep = " ";
            }
            Console.WriteLine();
        }
    }
}
