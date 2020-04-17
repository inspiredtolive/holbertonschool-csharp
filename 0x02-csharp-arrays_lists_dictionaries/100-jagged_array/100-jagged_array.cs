using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] array = {
            new int[] { 0, 1, 2, 3 },
            new int[] { 0, 1, 2, 3, 4, 5, 6 },
            new int[] { 0, 1 }
        };
        string sep = "";

        for (int i = 0; i < 3; i++)
        {
            sep = "";
            for (int j = 0; j < array[i].Length; j++)
			{
				Console.Write("{0}{1}", sep, array[i][j]);
                sep = " ";
			}
            Console.WriteLine();
        }
    }
}
