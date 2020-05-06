using NUnit.Framework;
using System.Collections.Generic;
using MyMath;

namespace Tests
{
    /// <summary>
    /// Provides Tests for Max().
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Tests for empty list.
        /// </summary>
        [Test]
        public void MaxEmptyList()
        {
            List<int> myList = new List<int>() {};

            Assert.That(MyMath.Operations.Max(myList), Is.EqualTo(0));
        }

        /// <summary>
        /// Tests for positive ints.
        /// </summary>
        [Test]
        public void MaxPositive()
        {
            List<int> myList = new List<int>() {98, 10, 0, 32, 8};

            Assert.That(MyMath.Operations.Max(myList), Is.EqualTo(98));
        }

        /// <summary>
        /// Tests for negative ints.
        /// </summary>
        [Test]
        public void MaxNegative()
        {
            List<int> myList = new List<int>() {-98, 10, 0, 32, 8, 475};

            Assert.That(MyMath.Operations.Max(myList), Is.EqualTo(475));
        }
    }
}
