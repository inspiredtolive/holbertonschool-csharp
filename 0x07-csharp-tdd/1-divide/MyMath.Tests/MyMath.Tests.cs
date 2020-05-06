using NUnit.Framework;
using MyMath;

namespace Tests
{
    /// <summary>
    /// Represents tests for MyMath.Matrix.
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Tests matrix division by zero.
        /// </summary>
        [Test]
        public void DivideZero()
        {
            int[,] matrix = { { 1, 3 }, { 9, 5 } };

            Assert.That(MyMath.Matrix.Divide(matrix, 0), Is.EqualTo(null));
        }

        /// <summary>
        /// Tests null Matrix.
        /// </summary>
        [Test]
        public void DivideNullMatrix()
        {
            int[,] matrix = null;

            Assert.That(MyMath.Matrix.Divide(matrix, 2), Is.EqualTo(null));
        }

        /// <summary>
        /// Tests null Matrix.
        /// </summary>
        [Test]
        public void DividePositive()
        {
            int[,] matrix = { { 36, 100 }, { 196, 9 } };
            int[,] result = { { 18, 50 }, { 98, 4 } };

            Assert.That(MyMath.Matrix.Divide(matrix, 2), Is.EqualTo(result));
        }

        /// <summary>
        /// Tests null Matrix.
        /// </summary>
        [Test]
        public void DivideNegative()
        {
            int[,] matrix = { { 36, -99 }, { 195, -9 } };
            int[,] result = { { -12, 33 }, { -65, 3 } };

            Assert.That(MyMath.Matrix.Divide(matrix, -3), Is.EqualTo(result));
        }
    }
}