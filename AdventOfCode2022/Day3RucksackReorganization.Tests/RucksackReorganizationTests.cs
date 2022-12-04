using Day3RucksackReorganization.Console;

namespace Day3RucksackReorganization.Tests
{
    [TestClass]
    public class RucksackReorganizationTests
    {
        [TestMethod]
        public void RucksackReorganizationTest1()
        {
            int totalScore = 0;

            RucksackReorganization rucksack1 = new RucksackReorganization();
            rucksack1.StoreInCompartment("vJrwpWtwJgWrhcsFMMfFFhFp");
            rucksack1.FindWrongStored();
            totalScore += rucksack1.CalculateWrongSortedPriority();

            RucksackReorganization rucksack2 = new RucksackReorganization();
            rucksack2.StoreInCompartment("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsS");
            rucksack2.FindWrongStored();
            totalScore += rucksack2.CalculateWrongSortedPriority();

            RucksackReorganization rucksack3 = new RucksackReorganization();
            rucksack3.StoreInCompartment("PmmdzqPrVvPwwTWBwg");
            rucksack3.FindWrongStored();
            totalScore += rucksack3.CalculateWrongSortedPriority();

            RucksackReorganization rucksack4 = new RucksackReorganization();
            rucksack4.StoreInCompartment("ttgJtRGJQctTZtZT");
            rucksack4.FindWrongStored();
            totalScore += rucksack4.CalculateWrongSortedPriority();

            RucksackReorganization rucksack5 = new RucksackReorganization();
            rucksack5.StoreInCompartment("CrZsJsPPZsGzwwsLwLmpwMDw");
            rucksack5.FindWrongStored();
            totalScore += rucksack5.CalculateWrongSortedPriority();

            Assert.AreEqual(157, totalScore);
        }
    }
}