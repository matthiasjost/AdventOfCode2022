namespace Day3RucksackReorganizationPart2.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read entire text file content in one string  
            string[] text = File.ReadAllLines("input.txt");
            int totalScore = 0;

            RucksackReorganizationList rucksackList = new RucksackReorganizationList();

            foreach (string line in text)
            {
                rucksackList.AddRucksack("","", "");
            }

            foreach (RucksackReorganizationItem rucksackItem in rucksackList.RucksackList)
            {
                rucksackItem.FindWrongStored();
                totalScore += rucksackItem.CalculateWrongSortedPriority();
            }
            System.Console.WriteLine(totalScore);
        }
    }
}