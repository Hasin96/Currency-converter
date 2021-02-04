using NUnit.Framework;

namespace MultiCurrencyMoney.UnitTests
{
    [TestFixture]
    public class Tests
    {
        public Tests()
        {

        }

        [Test]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.times(2);

            Assert.AreEqual(10, five.amount);
        }


    }
}