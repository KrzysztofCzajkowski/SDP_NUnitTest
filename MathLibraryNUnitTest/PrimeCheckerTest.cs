using System;
using AutoFixture;
using FluentAssertions;
using MathLibrary.MathLibrary;
using Moq;
using NUnit.Framework;

namespace MathLibraryNUnitTest
{
    public class PrimeCheckerTest
    {
        [Test]
        public void IsPrime_NegativeValue_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => PrimeChecker.IsPrime(-5));
        }

        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(6, false)]
        public void IsPrime_IntegerValue_ReturnsIsPrime(int value, bool expectedValue)
        {
            // act
            var actualValue = PrimeChecker.IsPrime(value);

            // assert
            actualValue.Should().Be(expectedValue);
        }
    }
}
