using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney.UnitTests
{
    [TestFixture]
    public class MoneyUnitTests
    {
        public MoneyUnitTests()
        {

        }

        [Test]
        public void Currency_CorrectCurrency_ReturnsCorrectCurrency()
        {
            StringAssert.Contains("USD", Money.Dollar(1).Currency());
        }

        [TestCase(2, 10)]
        [TestCase(3, 15)]
        public void Times_WhenCalledWithMultiplier_ReturnsNewFrancObjectWithTheExpectedAmount(int multiplier, int expectedAmount)
        {
            Money five = Money.Franc(5);

            Money product = five.Times(multiplier);

            Assert.AreEqual(product, Money.Franc(expectedAmount));
        }

        [TestCase(2, 10)]
        [TestCase(3, 15)]
        public void Times_WhenCalledWithMultiplier_ReturnsNewDollarObjectWithTheExpectedAmount(int multiplier, int expectedAmount)
        {
            Money five = Money.Dollar(5);

            Money product = five.Times(multiplier);

            Assert.AreEqual(product, Money.Dollar(expectedAmount));
        }

        [TestCase(5, 5, true)]
        [TestCase(5, 6, false)]
        public void Equals_CompareTwoDollarObjects_ReturnsExpected(int firstDollarAmount, int secondDollarAmount, bool expectedResult)
        {
            Money five1 = Money.Dollar(firstDollarAmount);
            Money five2 = Money.Dollar(secondDollarAmount);

            Assert.AreEqual(five1.Equals(five2), expectedResult);
        }

        [Test]
        public void Equals_CompareDollarToNull_ReturnsFalse()
        {
            Money five = Money.Dollar(5);
            object nullObj = null;

            Assert.IsFalse(five.Equals(nullObj));
        }

        public void Equals_CompareDollarToFrancObjects_ReturnsFalse()
        {
            Money five1 = Money.Dollar(5);
            Money five2 = Money.Franc(5);

            Assert.IsFalse(five1.Equals(five2));
        }
    }
}
