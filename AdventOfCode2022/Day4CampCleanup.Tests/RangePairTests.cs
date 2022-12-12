using Day4CampCleanup.Console;

namespace Day4CampCleanup.Tests
{
    [TestClass]
    public class RangePairTests
    {
        [TestMethod]
        public void CheckIfLeftContainsRightTrue()
        {
            RangePair rangePair = new RangePair();

            rangePair.Left.From = 2;
            rangePair.Left.To = 8;

            rangePair.Right.From = 3;
            rangePair.Right.To = 7;

            bool flag = rangePair.CheckIfLeftContainsRight();

            Assert.IsTrue(flag);

        }
        [TestMethod]
        public void CheckIfLeftContainsRightFalse()
        {
            RangePair rangePair = new RangePair();

            rangePair.Left.From = 2;
            rangePair.Left.To = 8;

            rangePair.Right.From = 3;
            rangePair.Right.To = 10;

            bool flag = rangePair.CheckIfLeftContainsRight();

            Assert.IsFalse(flag);

        }
    }
}