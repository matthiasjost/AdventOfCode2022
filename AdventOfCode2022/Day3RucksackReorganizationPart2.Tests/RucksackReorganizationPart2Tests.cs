using Day3RucksackReorganizationPart2.Console;

namespace Day3RucksackReorganizationPart2.Tests
{
    [TestClass]
    public class RucksackReorganizationPart2Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int totalScore = 0;

            RucksackReorganizationItem rucksack1 = new RucksackReorganizationItem();
            rucksack1.StoreInThreeRucksacks("vJrwpWtwJgWrhcsFMMfFFhFp", "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "PmmdzqPrVvPwwTWBwg");
            rucksack1.FindWrongStored();
            int score1 = rucksack1.CalculateWrongSortedPriority();

            RucksackReorganizationItem rucksack2 = new RucksackReorganizationItem();
            rucksack2.StoreInThreeRucksacks("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", "ttgJtRGJQctTZtZT", "CrZsJsPPZsGzwwsLwLmpwMDw");
            rucksack2.FindWrongStored();
            int score2 = rucksack2.CalculateWrongSortedPriority();

            totalScore = score1 + score2;
            Assert.AreEqual(70, totalScore);
        }
    }
}