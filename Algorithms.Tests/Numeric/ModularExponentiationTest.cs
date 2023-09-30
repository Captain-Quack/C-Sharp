using System;
using Algorithms.Numeric;
using FluentAssertions;
using NUnit.Framework;

namespace Algorithms.Tests.Numeric
{
    public class ModularExponentiationTest
    {
        [Test]
        [TestCase(3, 6, 11, 3)]
        [TestCase(5, 3, 13, 8)]
        [TestCase(2, 7, 17, 9)]
        [TestCase(7, 4, 16, 1)]
        [TestCase(7, 2, 11, 5)]
        [TestCase(4, 13, 497, 445)]
        [TestCase(13, 3, 1, 0)]
        public void ModularExponentiationCorrect(int b, int e, int m, int expectedRes)
        {
            var actualRes = ModularExponentiation.ModularPow(b, e, m);
            actualRes.Should().Be(expectedRes);
        }

        [TestCase(17, 7, -3)]
        [TestCase(11, 3, -5)]
        [TestCase(14, 3, 0)]
        public void ModularExponentiationNegativeMod(int b, int e, int m)
        {
            Action res = () => ModularExponentiation.ModularPow(b, e, m);
            res.Should().Throw<ArgumentException>()
            .WithMessage(string.Format("{0} is not a positive integer", m));
        }
    }
}
