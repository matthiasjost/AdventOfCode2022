using Day2RockPaperScissor;
using static Day2RockPaperScissor.SituationOutcomeType;

namespace Day2RockPaperScissor.Tests
{
    [TestClass]
    public class RockPaperScissorsCalculatorTests
    {
        [TestMethod]
        public void RockPaperScissorsCalculatorTest1()
        {
            RockPaperScissorsScoreCalculator calculator = new RockPaperScissorsScoreCalculator();

            calculator.AddRound("A", "Y");
            Assert.AreEqual(8, calculator.CalculateRounds());
        }
        [TestMethod]
        public void RockPaperScissorsCalculatorTest2()
        {
            RockPaperScissorsScoreCalculator calculator = new RockPaperScissorsScoreCalculator();
            calculator.AddRound("B", "X");
            Assert.AreEqual(1, calculator.CalculateRounds());

        }
        [TestMethod]
        public void RockPaperScissorsCalculatorTest3()
        {
            RockPaperScissorsScoreCalculator calculator = new RockPaperScissorsScoreCalculator();
            calculator.AddRound("C", "Z");
            Assert.AreEqual(6, calculator.CalculateRounds());
        }
    }


}