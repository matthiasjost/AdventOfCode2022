using Day3RucksackReorganization.Console;

namespace Day3RucksackReorganization.Tests
{
    [TestClass]
    public class RucksackReorganizationTests
    {
        [TestMethod]
        public void RucksackReorganizationTest1()
        {
            RucksackReorganization rucksackReorganization = new();
            char[] wrongSortedTypes = rucksackReorganization.AddRucksackAndGetWrongSortedType("vJrwpWtwJgWrhcsFMMfFFhFp");
            Assert.AreEqual('p', wrongSortedTypes[0]);
        }
    }
}