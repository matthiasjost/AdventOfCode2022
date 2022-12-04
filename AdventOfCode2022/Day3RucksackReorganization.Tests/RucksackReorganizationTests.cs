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
            
            RucksackReorganizationItem rucksack1 = new RucksackReorganizationItem();
            rucksack1.StoreInCompartment("vJrwpWtwJgWrhcsFMMfFFhFp");
            rucksack1.FindWrongStored();
            int score1 = rucksack1.CalculateWrongSortedPriority();

            RucksackReorganizationItem rucksack2 = new RucksackReorganizationItem();
            rucksack2.StoreInCompartment("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL");
            rucksack2.FindWrongStored();
            int score2 = rucksack2.CalculateWrongSortedPriority();

            RucksackReorganizationItem rucksack3 = new RucksackReorganizationItem();
            rucksack3.StoreInCompartment("PmmdzqPrVvPwwTWBwg");
            rucksack3.FindWrongStored();
            int score3 = rucksack3.CalculateWrongSortedPriority();

            RucksackReorganizationItem rucksack4 = new RucksackReorganizationItem();
            rucksack4.StoreInCompartment("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn");
            rucksack4.FindWrongStored();
            int score4 = rucksack4.CalculateWrongSortedPriority();

            RucksackReorganizationItem rucksack5= new RucksackReorganizationItem();
            rucksack5.StoreInCompartment("ttgJtRGJQctTZtZT");
            rucksack5.FindWrongStored();
            int score5 = rucksack5.CalculateWrongSortedPriority();

            RucksackReorganizationItem rucksack6 = new RucksackReorganizationItem();
            rucksack6.StoreInCompartment("CrZsJsPPZsGzwwsLwLmpwMDw");
            rucksack6.FindWrongStored();
            int score6 = rucksack6.CalculateWrongSortedPriority();

            totalScore = score1 + score2 + score3 + score4 + score5 + score6;
            Assert.AreEqual(157, totalScore);
        }
        [TestMethod]
        public void RucksackReorganizationTest3CalculateScoreA()
        {
            RucksackReorganizationItem rucksack = new RucksackReorganizationItem();
            rucksack.StoreInCompartment("AA");

            rucksack.FindWrongStored();
            int score = rucksack.CalculateWrongSortedPriority();

            Assert.AreEqual(27, score);
        }

        [TestMethod]
        public void RucksackReorganizationTest3CalculateScoreZ()
        {
            RucksackReorganizationItem rucksack = new RucksackReorganizationItem();
            rucksack.StoreInCompartment("ZZ");

            rucksack.FindWrongStored();
            int score = rucksack.CalculateWrongSortedPriority();

            Assert.AreEqual(52, score);
        }

        [TestMethod]
        public void RucksackReorganizationTest3CalculateScoreA2()
        {
            RucksackReorganizationItem rucksack = new RucksackReorganizationItem();
            rucksack.StoreInCompartment("aa");

            rucksack.FindWrongStored();
            int score = rucksack.CalculateWrongSortedPriority();

            Assert.AreEqual(1, score);
        }

        [TestMethod]
        public void RucksackReorganizationTest3CalculateScoreZ2()
        {
            RucksackReorganizationItem rucksack = new RucksackReorganizationItem();
            rucksack.StoreInCompartment("zz");

            rucksack.FindWrongStored();
            int score = rucksack.CalculateWrongSortedPriority();

            Assert.AreEqual(26, score);
        }

    }
}