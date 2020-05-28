using System;

///<summary>Class for vector math</summary>
class VectorMath
{
	///<summary>cross product of two vectors</summary>
	///<return>the result array or array with -1</return>
	public static double[] CrossProduct(double[] vector1, double[] vector2)
	{
		if (vector1.Length == 3 && vector2.Length == 3)
		{
			double a = vector1[1] * vector2[2] - (vector1[2] * vector2[1]);
			double b = vector1[2] * vector2[0] - (vector1[0] * vector2[2]);
			double c = vector1[0] * vector2[1] - (vector1[1] * vector2[0]);
			return new double[3] { a, b, c };
		}
		return new double[] { -1 };
	}
}

