using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney.UnitTests
{
    [TestFixture]
    class FrancUnitTests
    {
        public FrancUnitTests()
        {

        }

        [TestCase(2, 10)]
        [TestCase(3, 15)]
        public void Times_WhenCalledWithMultiplier_ReturnsNewFrancObjectWithTheExpectedAmount(int multiplier, int expectedAmount)
        {
            Franc five = new Franc(5);

            Franc product = five.Times(multiplier);

            Assert.AreEqual(product, new Franc(expectedAmount));
        }
    }
}
