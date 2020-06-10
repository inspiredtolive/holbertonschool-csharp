using System;

/// <summary>
/// Provides matrix operations.
/// </summary>
class MatrixMath
{
	/// <summary>
	/// Rotates a 2D matrix.
	/// </summary>
	/// <param name="matrix">The matrix to rotate.</param>
	/// <param name="angle">The angle to rotate by.</param>
	/// <returns>The rotated matrix.</returns>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		if (matrix.GetLength(1) > 2)
		{
			return new double[,] { { -1 } };
		}
		double[,] rotationMatrix = {
			{Math.Cos(angle), Math.Sin(angle)},
			{-1 * Math.Sin(angle), Math.Cos(angle)}
		};
		double[,] transformedPoint = new double[2, 2];

		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 2; j++)
			{
				for (int k = 0; k < 2; k++)
				{
					transformedPoint[i, j] = Math.Round(transformedPoint[i, j] + (matrix[i, k] * rotationMatrix[k, j]), 2);
				}
			}
		}
		return transformedPoint;
	}
}