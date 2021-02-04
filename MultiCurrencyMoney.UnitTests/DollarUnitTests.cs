using NUnit.Framework;

namespace MultiCurrencyMoney.UnitTests
{
    [TestFixture]
    public class DollarUnitTests
    {
        public DollarUnitTests()
        {

        }

        [TestCase(2, 10)]
        [TestCase(3, 15)]
        public void Times_WhenCalledWithMultiplier_ReturnsNewDollarObjectWithTheCorrectAmount(int multiplier, int expectedAmount)
        {
            Dollar five = new Dollar(5);

            Dollar product = five.Times(multiplier);

            Assert.AreEqual(expectedAmount, product.Amount);
        }

        [TestCase(5,5, true)]
        [TestCase(5, 6, false)]
        public void Equals_CompareTwoDollarObjects_ReturnsExpected(int firstDollarAmount, int secondDollarAmount, bool expectedResult)
        {
            Dollar five1 = new Dollar(firstDollarAmount);
            Dollar five2 = new Dollar(secondDollarAmount);

            Assert.AreEqual(five1.Equals(five2), expectedResult);
        }

    }
}