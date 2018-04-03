using System;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.True(true);
        }

        [Test]
        public void ExcetptionTest()
        {
            var rng = new Random();
            var numerator = rng.Next();
            var denominator = 0;
            var testObject = new TestObject();

            var result = Assert.Throws<DivideByZeroException>(() => testObject.DivideIntegers(numerator, denominator));

            Assert.AreEqual("Attempted to divide by zero.", result.Message);
        }
    }

    public class TestObject
    {
        public int DivideIntegers(int numerator, int denominator)
        {
            return numerator / denominator;
        }
    }
}
