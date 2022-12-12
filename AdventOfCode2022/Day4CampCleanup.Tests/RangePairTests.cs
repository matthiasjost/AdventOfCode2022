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

            rangePair.Left.SetRange(2, 8);
            rangePair.Right.SetRange(3, 7);

            bool flag = rangePair.CheckIfLeftContainsRight();

            Assert.IsTrue(flag);

        }
        [TestMethod]
        public void CheckIfLeftContainsRightFalse()
        {
            RangePair rangePair = new RangePair();

            rangePair.Left.SetRange(2, 8);
            rangePair.Right.SetRange(3, 10);

            bool flag = rangePair.CheckIfLeftContainsRight();

            Assert.IsFalse(flag);
        }

        [TestMethod]
        public void CheckIfRightContainsLeftTrue()
        {
            RangePair rangePair = new RangePair();

            rangePair.Left.SetRange(3, 7);
            rangePair.Right.SetRange(2, 8);

            bool flag = rangePair.CheckIfRightContainsLeft();

            Assert.IsTrue(flag);

        }
        [TestMethod]
        public void CheckIfRightContainsLeftFalse()
        {
            RangePair rangePair = new RangePair();

            rangePair.Left.SetRange(3, 10);
            rangePair.Right.SetRange(2, 8);

            bool flag = rangePair.CheckIfRightContainsLeft();

            Assert.IsFalse(flag);

        }
    }
}