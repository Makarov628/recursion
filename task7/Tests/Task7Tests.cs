using System;
using NUnit.Framework;
using Task7;

namespace Tests
{
    [TestFixture]
    public class Task7Tests
    {
        [Test]
        public void FindTwoMax()
        {
            var numbers = new int[] { 23, 4, 12, 234, 5, 42, 6, 4 };
            var (max1, max2) = Maximum.FindTwoMaxInArray(numbers);

            Assert.That(max1, Is.EqualTo(234));
            Assert.That(max2, Is.EqualTo(42));

            var numbers2 = new int[] { 2, 3, 5, 4 };
            var (max11, max22) = Maximum.FindTwoMaxInArray(numbers2);

            Assert.That(max11, Is.EqualTo(5));
            Assert.That(max22, Is.EqualTo(4));
        }

        [Test]
        public void FindTwoSameMax()
        {
            var numbers = new int[] { 5, 4, 3, 2, 5 };
            var (max1, max2) = Maximum.FindTwoMaxInArray(numbers);

            Assert.That(max1, Is.EqualTo(max2));
        }

    }
}
