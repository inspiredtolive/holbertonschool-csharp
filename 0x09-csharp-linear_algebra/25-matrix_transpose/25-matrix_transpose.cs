using System;


///<summary>Class for matrix math</summary>
class MatrixMath
{
	///<summary>calcuating matrix transposing</summary>
	///<return>the result matrix or empty matrix</return>
	public static double[,] Transpose(double[,] matrix)
	{
		int row = matrix.GetLength(0);
		int col = matrix.GetLength(1);
		double[,] result = new double[col, row];

		for (int i; i < col; i++)
		{
			for (intj; j < row; j++)
			{
				result[j][i] = matrix[i][j];
			}
		}
		return matrix;
	}
}
