using NUnit.Framework;
using MyMath;

namespace Tests
{
    /// <summary>
    /// Represents tests for MyMath.Operations.
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Tests addition with 0.
        /// </summary>
        [Test]
        public void AddZero()
        {
            Assert.That(MyMath.Operations.Add(0, 0), Is.EqualTo(0));
            Assert.That(MyMath.Operations.Add(7, 0), Is.EqualTo(7));
            Assert.That(MyMath.Operations.Add(0, 7), Is.EqualTo(7));
            Assert.That(MyMath.Operations.Add(-12, 0), Is.EqualTo(-12));
            Assert.That(MyMath.Operations.Add(0, -12), Is.EqualTo(-12));
        }

        /// <summary>
        /// Tests addition with positive ints.
        /// </summary>
        [Test]
        public void AddPositive()
        {
            Assert.That(MyMath.Operations.Add(4, 9), Is.EqualTo(13));
            Assert.That(MyMath.Operations.Add(16, 9), Is.EqualTo(25));
            Assert.That(MyMath.Operations.Add(25, 121), Is.EqualTo(146));
        }

        /// <summary>
        /// Tests addition with negative ints.
        /// </summary>
        [Test]
        public void AddNegative()
        {
            Assert.That(MyMath.Operations.Add(4, -9), Is.EqualTo(-5));
            Assert.That(MyMath.Operations.Add(-16, 9), Is.EqualTo(-7));
            Assert.That(MyMath.Operations.Add(-25, 121), Is.EqualTo(96));
        }
    }
}