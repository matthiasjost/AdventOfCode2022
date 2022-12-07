using Day2RockPaperScissors;
using Day2RockPaperScissors.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2RockPaperScissor.Tests
{
    [TestClass]
    public class RockPaperScissorsScoreCalculatorTests
    {
        [TestMethod]
        public void RockPaperScissorsScoreCalculatorTests1()
        {
            SituationOutcomeType.RockPaperScissorsScoreCalculator calculator = new SituationOutcomeType.RockPaperScissorsScoreCalculator();

            calculator.AddRound("A", "Y");
            Assert.AreEqual(8, calculator.CalculateRounds());
        }
        [TestMethod]
        public void RockPaperScissorsScoreCalculatorTests2()
        {
            SituationOutcomeType.RockPaperScissorsScoreCalculator calculator = new SituationOutcomeType.RockPaperScissorsScoreCalculator();
            calculator.AddRound("B", "X");
            Assert.AreEqual(1, calculator.CalculateRounds());

        }
        [TestMethod]
        public void RockPaperScissorsScoreCalculatorTest3()
        {
            SituationOutcomeType.RockPaperScissorsScoreCalculator calculator = new SituationOutcomeType.RockPaperScissorsScoreCalculator();
            calculator.AddRound("C", "Z");
            Assert.AreEqual(6, calculator.CalculateRounds());
        }
    }
}