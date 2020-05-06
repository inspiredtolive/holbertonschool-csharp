using System;

namespace MyMath
{
    /// <summary>
    /// Represents a Matrix.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides a matrix by an int.
        /// </summary>
        /// <param name="matrix">A multidimensional int array.</param>
        /// <param name="num">An int divisor.</param>
        /// <returns>The quotient matrix.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int [,] result;

            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
            }
            if (matrix == null || num == 0)
            {
                return null;
            }
            result = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j] / num;
                }
            }
            return result;
        }
    }
}
