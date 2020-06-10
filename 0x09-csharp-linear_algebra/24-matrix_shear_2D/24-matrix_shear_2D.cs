using System;

/// <summary>
/// Provides Matrix operations.
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Shears a 2D matrix.
	/// </summary>
	/// <param name="matrix">The matrix to shear.</param>
	/// <param name="direction">The direction to shear in.</param>
	/// <param name="factor">The factor to shear by.</param>
	/// <returns>The sheared matrix or a matrix containing -1.</returns>
	public static double[,] Shear2D(double[,] matrix, char direction, double factor)
	{
		double[,] result = new double[2,2];
		double[,] invalid = {{-1}};
		double[,] shearMatrix;

		if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
		{
			return invalid;
		}
		if (direction == 'x' || direction == 'y')
		{
			if (direction == 'x')
			{
				shearMatrix = new double[,] {{1, 0}, {factor, 1}};
			}
			else
			{
				shearMatrix = new double[,] {{1, factor}, {0, 1}};
			}
		}
		else
		{
			return invalid;
		}
		for (int i = 0; i < 2; i++)
			for (int j = 0; j < 2; j++)
				for (int k = 0; k < 2; k++)
					result[i, j] += (matrix[i, k] * shearMatrix[k, j]);
		return result;
	}
}
